package ITMD510.HW3.academic2;

import java.util.*;

public class Class2 extends Knowledge {
	String sectionID, dayOfWeek;
	
	Scanner scnClass = new Scanner(System.in);
	
	public ArrayList<String> classList = new ArrayList<>();
	
	public void createKnowledge(){
		System.out.print("Enter Class ID: ");
		id = scnClass.nextLine();
		classList.add(id);
		
		System.out.print("Enter Class Name: ");
		name = scnClass.nextLine();
		classList.add(name);
		
		System.out.print("Enter Section ID: ");
		sectionID = scnClass.nextLine();
		classList.add(sectionID);
		
		System.out.print("Enter Day of week separated by comma: ");
		dayOfWeek = scnClass.nextLine();
		classList.add(dayOfWeek);
		
		System.out.println("Congrats! You created a new Class...");
	}
	
	public void displayClass(){
		for(int a=0;a<classList.size();a+=4){	
			System.out.println("Classes - Course ID: "+classList.get(a).substring(0, 7)+", Name: "+classList.get(a+1)+", Section ID: "+classList.get(a+2)+", Days in week: "+classList.get(a+3));
		}
	}
}