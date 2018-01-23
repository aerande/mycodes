package ITMD510.HW3.academic;

import java.util.*;

public class Class {
	public String id,name,sectionID,dayOfWeek;
	
	public Scanner scnClass = new Scanner(System.in);
	
	public ArrayList<String> classList = new ArrayList<>();
	
	public void createClass(){
		System.out.print("Enter Class ID: ");
		id = scnClass.nextLine();
		classList.add(id);
		
		System.out.print("Enter Class Name: ");
		name = scnClass.nextLine();
		classList.add(name);
		
		System.out.print("Enter Class Section ID: ");
		sectionID = scnClass.nextLine();
		classList.add(sectionID);
		
		System.out.print("Enter Class Day in week: ");
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