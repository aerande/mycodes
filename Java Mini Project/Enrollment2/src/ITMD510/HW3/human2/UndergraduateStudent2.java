package ITMD510.HW3.human2;

import java.util.*;

public class UndergraduateStudent2 extends Person2 {
	public ArrayList<String> ungradstu = new ArrayList<>();
	public ArrayList<String> ungradstuclass = new ArrayList<>();
	
	public Scanner scnUnGradStu = new Scanner(System.in);
	
	public void createPerson(){
		System.out.print("Enter Undergrad ID: ");
		id = scnUnGradStu.nextLine();
		ungradstu.add(id);
		
		System.out.print("Enter Undergrad name: ");
		name = scnUnGradStu.nextLine();
		ungradstu.add(name);
		
		System.out.print("Enter Undergrad gender: ");
		gender = scnUnGradStu.nextLine();
		ungradstu.add(gender);
		
		System.out.println("Congrats! You created a new Undergrad student...");
	}
	
	public void displayPerson(){
		for(int a=0;a<ungradstu.size();a+=3){	
			System.out.println("Undergraduate students - ID: "+ungradstu.get(a)+", Name: "+ungradstu.get(a+1)+", Gender: "+ungradstu.get(a+2));
		}
	}
}