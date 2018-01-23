package ITMD510.HW3.program2;

import java.util.*;

import ITMD510.HW3.human2.GraduateStudent2;
import ITMD510.HW3.human2.UndergraduateStudent2;
import ITMD510.HW3.human2.Instructor2;
import ITMD510.HW3.academic2.Class2;
import ITMD510.HW3.academic2.Course2;

public class MyProgram2 {
	public static void main(String[] args) {
		System.out.println("Create your object:");
		System.out.println("1. Create a Graduate Student\n"
						  +"2. Create an Undergraduate Student\n"
						  +"3. Create an Instructor\n"
						  +"4. Create a Course\n"
						  +"5. Create a Class");
		System.out.println("---------------------------------------------");
		System.out.println("Complete your Enrollment:");
		System.out.println("6. Students enroll in Classes\n"
						  +"7. Instructor teaches Classes");
		System.out.println("---------------------------------------------");
		System.out.println("Output Functions:");
		System.out.println("8. A list of Students\n"
				          +"9. A list of Instructors\n"
						  +"10. A list of Classes\n"
				          +"11. A list of classes taken by a Student\n"
						  +"12. A list of classes taught by an Instructor");
		System.out.println("---------------------------------------------");
		System.out.println("-1. Exit");
		
		GraduateStudent2 g2 = new GraduateStudent2();
		UndergraduateStudent2 ug2 = new UndergraduateStudent2();
		Instructor2 i2 = new Instructor2();
		Course2 c2 = new Course2();
		Class2 cl2 = new Class2();
		
		while(true){
			Scanner scn = new Scanner(System.in);
			System.out.print("\nEnter your option: ");
			int i = scn.nextInt();
			
			switch(i){
				case 1:
					g2.createPerson();
				break;
				
				case 2:
					ug2.createPerson();
				break;
				
				case 3:
					i2.createPerson();
				break;
				
				case 4:
					c2.createKnowledge();
				break;
				
				case 5:
					cl2.createKnowledge();
				break;
				
				case 6:
					boolean loopOuter = true;
					
					while(loopOuter){
						System.out.print("\nEnter 1 for Graduate Students & 2 for Undergraduate Students: ");
						int j = scn.nextInt();
						if(j==1){
							boolean loop = true;
					
							System.out.println("Graduate students list:");
							for(int a=0;a<g2.gradstu.size();a+=3){	
								System.out.println("Select-- "+g2.gradstu.indexOf(g2.gradstu.get(a))+"  ID: "+g2.gradstu.get(a));
							}
					
							System.out.print("\nEnter selection number: ");
							int inp = g2.scnGradStu.nextInt();
							String inp1 = g2.gradstu.get(inp);
							g2.gradstuclass.add(inp1);
					
							System.out.println("List of classes:");
							for(int q=0;q<cl2.classList.size();q+=4){
								System.out.println("Select-- "+cl2.classList.indexOf(cl2.classList.get(q))+"  ID: "+cl2.classList.get(q));
							}
					
							System.out.print("Enter selection number: ");
							int inps1 = g2.scnGradStu.nextInt();
							String inpc1 = cl2.classList.get(inps1);
							g2.gradstuclass.add(inpc1);
							
							while(loop){
								System.out.print("Enter selection number: ");
								int inps2 = g2.scnGradStu.nextInt();
								String inpc2 = cl2.classList.get(inps2);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								if(inpcs1.toLowerCase().equals(inpcs2.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;
								}
								else{
									g2.gradstuclass.add(inpc2);
									System.out.println("Congrats! A Grad student has enrolled in Classes!");
									loop = false;
									loopOuter = false;
								}
							}
						}
						else if(j==2){
							boolean loop = true, loop1 = true;
							String inpc1=null,inpc2=null,inpc3=null;
						
							System.out.println("Undergraduate students list:");
							for(int a=0;a<ug2.ungradstu.size();a+=3){	
								System.out.println("Select-- "+ug2.ungradstu.indexOf(ug2.ungradstu.get(a))+"  ID: "+ug2.ungradstu.get(a));
							}
					
							System.out.print("\nEnter selection number: ");
							int inp = ug2.scnUnGradStu.nextInt();
							String inp1 = ug2.ungradstu.get(inp);
							ug2.ungradstuclass.add(inp1);
					
							System.out.println("List of classes:");
							for(int q=0;q<cl2.classList.size();q+=4){
								System.out.println("Select-- "+cl2.classList.indexOf(cl2.classList.get(q))+"  ID: "+cl2.classList.get(q));
							}
					
							System.out.print("Enter selection number: ");
							int inps1 = ug2.scnUnGradStu.nextInt();
							inpc1 = cl2.classList.get(inps1);
							ug2.ungradstuclass.add(inpc1);
							
							while(loop){
								System.out.print("Enter selection number: ");
								int inps2 = ug2.scnUnGradStu.nextInt();
								inpc2 = cl2.classList.get(inps2);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								if(inpcs1.toLowerCase().equals(inpcs2.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;
								}
								else{
									ug2.ungradstuclass.add(inpc2);
									loop = false;
								}
							}
						
							while(loop1){
								System.out.print("Enter selection number: ");
								int inps3 = ug2.scnUnGradStu.nextInt();
								inpc3 = cl2.classList.get(inps3);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								String inpcs3 = inpc3.substring(0, 6);
								if(inpcs2.toLowerCase().equals(inpcs3.toLowerCase()) ||
								   inpcs1.toLowerCase().equals(inpcs3.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;	
								}
								else{
									ug2.ungradstuclass.add(inpc3);
									System.out.println("Congrats! An Undergrad student has enrolled in Classes!");
									loop1 = false;
									loopOuter = false;
								}
							}
						}
						else{
							System.out.println("Please enter either 1 or 2!");
							continue;
						}
					}
				break;
				
				case 7:
					System.out.println("Instructors list:");
					for(int a=0;a<i2.instructor.size();a+=3){	
						System.out.println("Select-- "+i2.instructor.indexOf(i2.instructor.get(a))+"  ID: "+i2.instructor.get(a));
					}
				
					System.out.print("\nEnter selection number: ");
					int inp = i2.scnInstructor.nextInt();
					String inp1 = i2.instructor.get(inp);
					i2.instructorclass.add(inp1);
				
					System.out.println("List of classes:");
					for(int q=0;q<cl2.classList.size();q+=4){
						System.out.println("Select-- "+cl2.classList.indexOf(cl2.classList.get(q))+"  ID: "+cl2.classList.get(q));
					}
				
					System.out.print("\nEnter selection number: ");
					int inps1 = i2.scnInstructor.nextInt();
					String inpc1 = cl2.classList.get(inps1);
					i2.instructorclass.add(inpc1);
							
					System.out.print("\nEnter selection number: ");
					int inps2 = i2.scnInstructor.nextInt();
					String inpc2 = cl2.classList.get(inps2);
					i2.instructorclass.add(inpc2);
					
					System.out.println("Congrats! An Instructor has enrolled in Classes to teach!");
				break;
				
				case 8:
					g2.displayPerson();
					ug2.displayPerson();
				break;
				
				case 9:
					i2.displayPerson();
				break;
				
				case 10:
					cl2.displayClass();
				break;
				
				case 11:
					String cs1=null,cs2=null,cs3=null;
					boolean loopOuter2 = true;
					
					while(loopOuter2){
						System.out.print("\nEnter 1 for Graduate Students & 2 for Undergraduate Students: ");
						int k = scn.nextInt();
						if(k==1){
							System.out.println("Grad students list:");
							for(int a=0;a<g2.gradstu.size();a+=3){	
								System.out.println("Select-- "+g2.gradstu.indexOf(g2.gradstu.get(a))+"  ID: "+g2.gradstu.get(a));
							}
							System.out.print("Select Grad student from the list by selection: ");
							int sel = scn.nextInt();
							String sel1 = g2.gradstu.get(sel);
						
							for(int s=g2.gradstuclass.indexOf(sel1);s<g2.gradstuclass.indexOf(sel1)+2;s++){
								cs1 = g2.gradstuclass.get(s);
								cs2 = g2.gradstuclass.get(s+1);
							}
										
							System.out.println("\nThe Grad student with ID: '"+sel1+"' has taken these classes:");
						
							for(int c=cl2.classList.indexOf(cs1);c<cl2.classList.indexOf(cs1)+1;c++){
								System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
							}
						
							for(int c=cl2.classList.indexOf(cs2);c<cl2.classList.indexOf(cs2)+1;c++){
								System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
							}
							loopOuter2 = false;
						}
						else if(k==2){
							System.out.println("Undergrad students list:");
							for(int a=0;a<ug2.ungradstu.size();a+=3){	
								System.out.println("Select-- "+ug2.ungradstu.indexOf(ug2.ungradstu.get(a))+"  ID: "+ug2.ungradstu.get(a));
							}
							System.out.print("Select Grad student from the list by selection: ");
							int sel = scn.nextInt();
							String sel1 = ug2.ungradstu.get(sel);
						
							for(int s=ug2.ungradstuclass.indexOf(sel1);s<ug2.ungradstuclass.indexOf(sel1)+2;s++){
								cs1 = ug2.ungradstuclass.get(s);
								cs2 = ug2.ungradstuclass.get(s+1);
								cs3 = ug2.ungradstuclass.get(s+2);
							}
							
							System.out.println("\nThe Undergrad student with ID: '"+sel1+"' has taken these classes:");
							
							for(int c=cl2.classList.indexOf(cs1);c<cl2.classList.indexOf(cs1)+1;c++){
								System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
							}
						
							for(int c=cl2.classList.indexOf(cs2);c<cl2.classList.indexOf(cs2)+1;c++){
								System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
							}
						
							for(int c=cl2.classList.indexOf(cs3);c<cl2.classList.indexOf(cs3)+1;c++){
								System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
							}
							loopOuter2 = false;
						}
						else{
							System.out.println("Please enter either 1 or 2!");
							continue;
						}
					}
				break;
				
				case 12:
					String csi1=null,csi2=null;
					
					System.out.println("Instructors list:");
					for(int a=0;a<i2.instructor.size();a+=3){	
						System.out.println("Select-- "+i2.instructor.indexOf(i2.instructor.get(a))+"  ID: "+i2.instructor.get(a));
					}
					
					System.out.print("Select Instructor from the list by selection: ");
					int sel = scn.nextInt();
					String sel1 = i2.instructor.get(sel);
					
					for(int s=i2.instructorclass.indexOf(sel1);s<i2.instructorclass.indexOf(sel1)+2;s++){
						csi1 = i2.instructorclass.get(s);
						csi2 = i2.instructorclass.get(s+1);
					}
					
					System.out.println("\nThe Instructor with ID: '"+sel1+"' teaches this/these classes:");
					
					for(int c=cl2.classList.indexOf(csi1);c<cl2.classList.indexOf(csi1)+1;c++){
						System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
					}
					
					for(int c=cl2.classList.indexOf(csi2);c<cl2.classList.indexOf(csi2)+1;c++){
						System.out.println("Class - Class ID: "+cl2.classList.get(c)+", Name: "+cl2.classList.get(c+1)+", Section ID: "+cl2.classList.get(c+2)+", Days in week: "+cl2.classList.get(c+3));
					}
				break;
				
				case -1:
					System.out.println("Thank you!");
					System.exit(0);
				break;
				
				default:
					System.out.println("Please enter choice between 1 to 12 & -1 to exit!");
				break;
			}
		}
	}
}