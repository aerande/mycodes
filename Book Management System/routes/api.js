var express = require('express');
var router = express.Router();
var _ = require('underscore');

var books = [
    {
        id: 1,
        name: "The Bad Beginning",
        author: "Lemony Snicket",
        price: 6.91,
        published: 2012,
        stars: 4.8,
        rating: 1840,
        image: "/images/book_image_1.jpg"
    },
    {
        id: 2,
        name: "A Wrinkle In Time",
        author: "Madeleine L'Engle",
        price: 6.99,
        published: 2010,
        stars: 4.5,
        rating: 2393,
        image: "/images/book_image_2.jpg"
    },
    {
        id: 3,
        name: "A Brief History of Time",
        author: "Stephen Hawking",
        price: 10.59,
        published: 2008,
        stars: 4.6,
        rating: 1718,
        image: "/images/book_image_3.jpg"
    },
    {
        id: 4,
        name: "Brave New World",
        author: "Aldous Huxley",
        price: 14.99,
        published: 2014,
        stars: 4.0,
        rating: 1139,
        image: "/images/book_image_4.jpg"
    },
    {
        id: 5,
        name: "The Pelican Brief",
        author: "John Grisham",
        price: 7.99,
        published: 1992,
        stars: 4.4,
        rating: 7560,
        image: "/images/book_image_5.jpg"
    }
];

function lookupBook(book_id) {
  return _.find(books, function(c) {
    return c.id == parseInt(book_id);
  });
}

router.get('/books', function(req, res, next) {
  res.json(books);
});

router.route('/books/:book_id')
	.all(function(req, res, next){
		var book_id = req.params.book_id;
		book = lookupBook(book_id);
		next();
	})
    .get(function(req, res, next) {
		res.json(book);
	});

module.exports = router;