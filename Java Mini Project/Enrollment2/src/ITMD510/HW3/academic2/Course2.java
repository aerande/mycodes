package ITMD510.HW3.academic2;

import java.util.*;

public class Course2 extends Knowledge {
	ArrayList<String> course = new ArrayList<>();
	
	Scanner scnCourse = new Scanner(System.in);
	
	public void createKnowledge(){
		System.out.print("Enter Course ID: ");
		id = scnCourse.nextLine();
		course.add(id);
		
		System.out.print("Enter Course name: ");
		name = scnCourse.nextLine();
		course.add(name);
		
		System.out.println("Congrats! You created a new Course...");
	}
}
