(function(){
	
var db;

$(function() {
	var openRequest = indexedDB.open("notelist", 1);

	openRequest.onupgradeneeded = function (e) {
		console.log("Upgrading DB...");
		var thisDB = e.target.result;
		if (!thisDB.objectStoreNames.contains("notelisttore")) {
			thisDB.createObjectStore("notelisttore", { autoIncrement: true });
		}
	}
	openRequest.onsuccess = function () {
		console.log("Open Success!");
		db = openRequest.result;
		renderList();
	}
	openRequest.onerror = function () {
		alert("Open Error!");
	}
});

function initiality() {
	document.getElementById('subject_textfield').value = '';
	document.getElementById('message_textarea').value = '';
	document.getElementById('author_textfield').value = '';
	document.getElementById('addList').style.display = 'block';
	document.getElementById('updateList').style.display = 'none';
	document.getElementById('addNew').style.display = 'block';
	renderList();
}

document.getElementById('addNew').addEventListener('click', addNewEvent, false);

function addNewEvent() {
	document.getElementById('subject_textfield').value = '';
	document.getElementById('message_textarea').value = '';
	document.getElementById('author_textfield').value = '';
	this.style.display = 'none';
	document.getElementById('addTable').style.display = 'block';
	document.getElementById('updateList').style.display = 'none';

}

document.getElementById('cancelEverything').addEventListener('click', function() {
	initiality();
});


document.getElementById('addList').addEventListener('click', addListEvent, false);

function addListEvent() {
	var subject_text = ignoreString(document.getElementById('subject_textfield').value);
	var message_text = ignoreString(document.getElementById('message_textarea').value);
	var author_text = ignoreString(document.getElementById('author_textfield').value);
	if (!subject_text.trim() || !message_text.trim() || !author_text.trim()) {
		alert('Enter value in the fields!');
	}
	else {
		addDetails(subject_text, message_text, author_text);
	}
}


function addDetails(t1, t2, t3) {
	var dateTimeString = generateDateTime();
	var transaction = db.transaction(["notelisttore"], "readwrite");
	var store = transaction.objectStore("notelisttore");
	var request = store.add({ Subject: t1, Message: t2, Author: t3, DateTime: dateTimeString });
	request.onerror = function () {
		console.log("error");
	}
	request.onsuccess = function () {
		renderList();
		document.getElementById('subject_textfield').value = '';
		document.getElementById('message_textarea').value = '';
		document.getElementById('author_textfield').value = '';
		document.getElementById('addTable').style.display = 'none';
		document.getElementById('addNew').style.display = 'block';
	}
}

function renderList() {
	$('#detailedview').empty();
	$('#listBody').empty();
	$('#countCharacHead').hide();
	$('#countCharac').hide();
	$('#addTable').hide();

	var objectStore = db.transaction("notelisttore").objectStore("notelisttore");
	objectStore.openCursor().onsuccess = function (event) {
		var cursor = event.target.result;
		if (cursor) {
			var $link = $('<a href="#" data-key="' + cursor.key + '">' + cursor.value.Subject + '</a>');
			var datetime = cursor.value.DateTime;
			$link.click(function () {
				loadNoteByKey(parseInt($(this).attr('data-key')));
			});
			var $row = $('<tr></tr>');
			var $textCell1 = $('<td></td>').append($link);
			var $textCell2 = $('<td></td>').append(datetime);
			$($row).append($textCell1);
			$($row).append($textCell2);
			$('#listBody').append($row);
			cursor.continue();
		}
		else {
			
		}
		countNotes();
	};
}

function countNotes() {
	$('#countNo').text('');
	var transaction = db.transaction(['notelisttore'], 'readonly');
	var objectStore = transaction.objectStore('notelisttore');

	var countRequest = objectStore.count();
	countRequest.onsuccess = function () {
		$('#countNo').text(countRequest.result);
	}
}

function loadNoteByKey(key) {
	$('#detailedview').empty();
	var transaction = db.transaction(['notelisttore'], 'readonly');
	var store = transaction.objectStore('notelisttore');
	var request = store.get(key);
	request.onerror = function (event) {
		alert('Nothing to display!');
	};
	request.onsuccess = function (event) {
		var $sub = $('<h2>' + request.result.Subject + '</h2>');
		var $message = $('<p>' + request.result.Message + '</p>');
		var $auth = $('<h4>' + request.result.Author + '</h4>');
		var $datetime = $('<h6>' + request.result.DateTime + '</h6>');
		var $delBtn = $('<button class="btn btn-danger">Delete</button>');
		$delBtn.click(function () {
			deleteNote(key);
		});
		var $uptBtn = $('<button class="btn btn-primary" id="uptBtn">Update</button>');
		$uptBtn.click(function () {
			updateNote(key);
		});
		var $clearBtn = $('<button class="btn btn-default" id="clearBtn">Clear</button>');
		$clearBtn.click(function () {
			initiality();
		});
		$('#detailedview').append($sub);
		$('#detailedview').append($message);
		$('#detailedview').append($auth);
		$('#detailedview').append($datetime);
		$('#detailedview').append($delBtn);
		$('#detailedview').append($uptBtn);
		$('#detailedview').append($clearBtn);

		$('#countCharacHead').show();
		$('#countCharac').show();
		$('#countCharac').text('');
		var len = $message.text().length;
		$('#countCharac').text(len);
	};
}

function deleteNote(key) {
	var transaction = db.transaction(['notelisttore'], 'readwrite');
	var store = transaction.objectStore('notelisttore');
	var request = store.delete(key);
	request.onsuccess = function () {
		renderList();
		$('#detailedview').empty();
	};
}

function updateNote(key) {
	document.getElementById('addNew').style.display = 'none';
	document.getElementById('addTable').style.display = 'block';
	document.getElementById('addList').style.display = 'none';
	document.getElementById('updateList').style.display = 'block';

	var transaction = db.transaction(['notelisttore'], 'readonly');
	var store = transaction.objectStore('notelisttore');
	var request = store.get(key);
	request.onerror = function (event) {
		alert("Couldn't connect");
	};
	request.onsuccess = function () {
		var s = request.result.Subject;
		var m = request.result.Message;
		var a = request.result.Author;
		$('#subject_textfield').val(s);
		$('#message_textarea').val(m);
		$('#author_textfield').val(a);

		$('#updateList').click(function () {
			updateIt(key);
		});
	};
}

function updateIt(key) {
	var transaction = db.transaction(['notelisttore'], 'readwrite');
	var store = transaction.objectStore('notelisttore');

	store.openCursor().onsuccess = function (event) {
		var cursor = event.target.result;
		if (cursor) {
			if (cursor.key == key) {
				var dateTimeString = generateDateTime();
				var udata = cursor.value;
				udata.Subject = $('#subject_textfield').val();
				udata.Message = $('#message_textarea').val();
				udata.Author = $('#author_textfield').val();
				udata.DateTime = dateTimeString;
				var request1 = cursor.update(udata);
				request1.onerror = function () {
					alert('Update not successful! Please try again!');
				};
				request1.onsuccess = function () {
					renderList();
					document.getElementById('addList').style.display = 'block';
					document.getElementById('updateList').style.display = 'none';
					document.getElementById('addTable').style.display = 'none';
					document.getElementById('addNew').style.display = 'block';
				};
			}
			cursor.continue();
		}
		else {

		}
	};
}

function generateDateTime() {
	var datetime = new Date();

	// format the output
	var month = datetime.getMonth() + 1;
	var day = datetime.getDate();
	var year = datetime.getFullYear();

	var hour = datetime.getHours();
	if (hour < 10)
		hour = "0" + hour;

	var min = datetime.getMinutes();
	if (min < 10)
		min = "0" + min;

	var sec = datetime.getSeconds();
	if (sec < 10)
		sec = "0" + sec;

	// put it all together
	return month + '/' + day + '/' + year + ' ' + hour + ':' + min + ':' + sec;
}

function ignoreString(text) {
	text = text.replace(/&/g, '&amp;');
	text = text.replace(/</g, '&lt;');
	text = text.replace(/>/g, '&gt;');
	return text;
}

$(document).ready(function () {
	$("#listView").height($(document).height() - $(".content-wrapper").height());
	$("#listView1").height($("#listView").height() - $("#listView2").height());
	$("#detailedview").height($(document).height() - $(".content-wrapper").height());
	$("#addNoteDiv").height($(document).height() - $(".content-wrapper").height());
});

})();