package ITMD510.HW3.human;

import java.util.*;

public class GraduateStudent {
	public String id,name,gender;
	
	public ArrayList<String> gradstu = new ArrayList<>();
	public ArrayList<String> gradstuclass = new ArrayList<>();
	
	public Scanner scnGradStu = new Scanner(System.in);
	
	public void createGradStudent(){
		System.out.print("Enter Grad ID: ");
		id = scnGradStu.nextLine();
		gradstu.add(id);
		
		System.out.print("Enter Grad name: ");
		name = scnGradStu.nextLine();
		gradstu.add(name);
		
		System.out.print("Enter Grad gender: ");
		gender = scnGradStu.nextLine();
		gradstu.add(gender);
		
		System.out.println("Congrats! You created a new Grad student...");
	}
	
	public void displayGradStudent(){
		for(int a=0;a<gradstu.size();a+=3){	
				System.out.println("Graduate students - ID: "+gradstu.get(a)+", Name: "+gradstu.get(a+1)+", Gender: "+gradstu.get(a+2));
		}
	}
}