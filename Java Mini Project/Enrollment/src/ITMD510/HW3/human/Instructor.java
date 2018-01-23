package ITMD510.HW3.human;

import java.util.*;

public class Instructor {
	public String id,name,gender;
	
	public ArrayList<String> instructor = new ArrayList<>();
	public ArrayList<String> instructorclass = new ArrayList<>();
	
	public Scanner scnInstructor = new Scanner(System.in);
	
	public void createInstructor(){
		System.out.print("Enter Instructor ID: ");
		id = scnInstructor.nextLine();
		instructor.add(id);
		
		System.out.print("Enter Instructor name: ");
		name = scnInstructor.nextLine();
		instructor.add(name);
		
		System.out.print("Enter Instructor gender: ");
		gender = scnInstructor.nextLine();
		instructor.add(gender);
		
		System.out.println("Congrats! You created a new Instructor...");
	}
	
	public void displayInstructor(){
		for(int a=0;a<instructor.size();a+=3){	
			System.out.println("Instructors - ID: "+instructor.get(a)+", Name: "+instructor.get(a+1)+", Gender: "+instructor.get(a+2));
		}
	}
}