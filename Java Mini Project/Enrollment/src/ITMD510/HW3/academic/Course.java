package ITMD510.HW3.academic;

import java.util.*;

public class Course {
	private String id,name;
	
	ArrayList<String> course = new ArrayList<>();
	
	Scanner scnCourse = new Scanner(System.in);
	
	public void createCourse(){
		System.out.print("Enter Course ID: ");
		id = scnCourse.nextLine();
		course.add(id);
		
		System.out.print("Enter Course name: ");
		name = scnCourse.nextLine();
		course.add(name);
		
		System.out.println("Congrats! You created a new Course...");
	}
}