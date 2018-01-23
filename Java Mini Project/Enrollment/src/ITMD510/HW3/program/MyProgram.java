package ITMD510.HW3.program;

import java.util.*;

import ITMD510.HW3.human.GraduateStudent;
import ITMD510.HW3.human.Instructor;
import ITMD510.HW3.human.UndergraduateStudent;
import ITMD510.HW3.academic.Course;
import ITMD510.HW3.academic.Class;

public class MyProgram {

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
		
		GraduateStudent g1 = new GraduateStudent();
		UndergraduateStudent ug1 = new UndergraduateStudent();
		Instructor i1 = new Instructor();
		Course c1 = new Course();
		Class cl1 = new Class();
		
		while(true){
			Scanner scn = new Scanner(System.in);
			System.out.print("\nEnter your option: ");
			int i = scn.nextInt();

			switch(i){
				case 1:
					g1.createGradStudent();
				break;
				
				case 2:
					ug1.createUndergradStudent();
				break;
				
				case 3:
					i1.createInstructor();
				break;
				
				case 4:
					c1.createCourse();
				break;
				
				case 5:
					cl1.createClass();
				break;
				
				case 6:
					boolean loopOuter = true;
					
					while(loopOuter){
						System.out.print("\nEnter 1 for Graduate Students & 2 for Undergraduate Students: ");
						int j = scn.nextInt();
						if(j==1){
							boolean loop = true;
					
							System.out.println("Graduate students list:");
							for(int a=0;a<g1.gradstu.size();a+=3){	
								System.out.println("Select-- "+g1.gradstu.indexOf(g1.gradstu.get(a))+"  ID: "+g1.gradstu.get(a));
							}
					
							System.out.print("\nEnter selection number: ");
							int inp = g1.scnGradStu.nextInt();
							String inp1 = g1.gradstu.get(inp);
							g1.gradstuclass.add(inp1);
					
							System.out.println("List of classes:");
							for(int q=0;q<cl1.classList.size();q+=4){
								System.out.println("Select-- "+cl1.classList.indexOf(cl1.classList.get(q))+"  ID: "+cl1.classList.get(q));
							}
					
							System.out.print("Enter selection number: ");
							int inps1 = g1.scnGradStu.nextInt();
							String inpc1 = cl1.classList.get(inps1);
							g1.gradstuclass.add(inpc1);
							
							while(loop){
								System.out.print("Enter selection number: ");
								int inps2 = g1.scnGradStu.nextInt();
								String inpc2 = cl1.classList.get(inps2);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								if(inpcs1.toLowerCase().equals(inpcs2.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;
								}
								else{
									g1.gradstuclass.add(inpc2);
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
							for(int a=0;a<ug1.ungradstu.size();a+=3){	
								System.out.println("Select-- "+ug1.ungradstu.indexOf(ug1.ungradstu.get(a))+"  ID: "+ug1.ungradstu.get(a));
							}
					
							System.out.print("\nEnter selection number: ");
							int inp = ug1.scnUnGradStu.nextInt();
							String inp1 = ug1.ungradstu.get(inp);
							ug1.ungradstuclass.add(inp1);
					
							System.out.println("List of classes:");
							for(int q=0;q<cl1.classList.size();q+=4){
								System.out.println("Select-- "+cl1.classList.indexOf(cl1.classList.get(q))+"  ID: "+cl1.classList.get(q));
							}
					
							System.out.print("Enter selection number: ");
							int inps1 = ug1.scnUnGradStu.nextInt();
							inpc1 = cl1.classList.get(inps1);
							ug1.ungradstuclass.add(inpc1);
							
							while(loop){
								System.out.print("Enter selection number: ");
								int inps2 = ug1.scnUnGradStu.nextInt();
								inpc2 = cl1.classList.get(inps2);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								if(inpcs1.toLowerCase().equals(inpcs2.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;
								}
								else{
									ug1.ungradstuclass.add(inpc2);
									loop = false;
								}
							}
						
							while(loop1){
								System.out.print("Enter selection number: ");
								int inps3 = ug1.scnUnGradStu.nextInt();
								inpc3 = cl1.classList.get(inps3);
							
								String inpcs1 = inpc1.substring(0, 6);
								String inpcs2 = inpc2.substring(0, 6);
								String inpcs3 = inpc3.substring(0, 6);
								if(inpcs2.toLowerCase().equals(inpcs3.toLowerCase()) ||
								   inpcs1.toLowerCase().equals(inpcs3.toLowerCase())){
									System.out.println("Please select class from a different course!");
									continue;	
								}
								else{
									ug1.ungradstuclass.add(inpc3);
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
					for(int a=0;a<i1.instructor.size();a+=3){	
						System.out.println("Select-- "+i1.instructor.indexOf(i1.instructor.get(a))+"  ID: "+i1.instructor.get(a));
					}
				
					System.out.print("\nEnter selection number: ");
					int inp = i1.scnInstructor.nextInt();
					String inp1 = i1.instructor.get(inp);
					i1.instructorclass.add(inp1);
				
					System.out.println("List of classes:");
					for(int q=0;q<cl1.classList.size();q+=4){
						System.out.println("Select-- "+cl1.classList.indexOf(cl1.classList.get(q))+"  ID: "+cl1.classList.get(q));
					}
				
					System.out.print("\nEnter selection number: ");
					int inps1 = i1.scnInstructor.nextInt();
					String inpc1 = cl1.classList.get(inps1);
					i1.instructorclass.add(inpc1);
							
					System.out.print("\nEnter selection number: ");
					int inps2 = i1.scnInstructor.nextInt();
					String inpc2 = cl1.classList.get(inps2);
					i1.instructorclass.add(inpc2);
					
					System.out.println("Congrats! An Instructor has enrolled in Classes to teach!");
				break;
				
				case 8:
					g1.displayGradStudent();
					ug1.displayUndergradStudent();
				break;
				
				case 9:
					i1.displayInstructor();
				break;
				
				case 10:
					cl1.displayClass();
				break;
				
				case 11:
					String cs1=null,cs2=null,cs3=null;
					boolean loopOuter2 = true;
					
					while(loopOuter2){
						System.out.print("\nEnter 1 for Graduate Students & 2 for Undergraduate Students: ");
						int k = scn.nextInt();
						if(k==1){
							System.out.println("Grad students list:");
							for(int a=0;a<g1.gradstu.size();a+=3){	
								System.out.println("Select-- "+g1.gradstu.indexOf(g1.gradstu.get(a))+"  ID: "+g1.gradstu.get(a));
							}
							System.out.print("Select Grad student from the list by selection: ");
							int sel = scn.nextInt();
							String sel1 = g1.gradstu.get(sel);
						
							for(int s=g1.gradstuclass.indexOf(sel1);s<g1.gradstuclass.indexOf(sel1)+2;s++){
								cs1 = g1.gradstuclass.get(s);
								cs2 = g1.gradstuclass.get(s+1);
							}
										
							System.out.println("\nThe Grad student with ID: '"+sel1+"' has taken these classes:");
						
							for(int c=cl1.classList.indexOf(cs1);c<cl1.classList.indexOf(cs1)+1;c++){
								System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
							}
						
							for(int c=cl1.classList.indexOf(cs2);c<cl1.classList.indexOf(cs2)+1;c++){
								System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
							}
							loopOuter2 = false;
						}
						else if(k==2){
							System.out.println("Undergrad students list:");
							for(int a=0;a<ug1.ungradstu.size();a+=3){	
								System.out.println("Select-- "+ug1.ungradstu.indexOf(ug1.ungradstu.get(a))+"  ID: "+ug1.ungradstu.get(a));
							}
							System.out.print("Select Undergrad student from the list by selection: ");
							int sel = scn.nextInt();
							String sel1 = ug1.ungradstu.get(sel);
						
							for(int s=ug1.ungradstuclass.indexOf(sel1);s<ug1.ungradstuclass.indexOf(sel1)+2;s++){
								cs1 = ug1.ungradstuclass.get(s);
								cs2 = ug1.ungradstuclass.get(s+1);
								cs3 = ug1.ungradstuclass.get(s+2);
							}
							
							System.out.println("\nThe Undergrad student with ID: '"+sel1+"' has taken these classes:");
							
							for(int c=cl1.classList.indexOf(cs1);c<cl1.classList.indexOf(cs1)+1;c++){
								System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
							}
						
							for(int c=cl1.classList.indexOf(cs2);c<cl1.classList.indexOf(cs2)+1;c++){
								System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
							}
						
							for(int c=cl1.classList.indexOf(cs3);c<cl1.classList.indexOf(cs3)+1;c++){
								System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
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
					for(int a=0;a<i1.instructor.size();a+=3){	
						System.out.println("Select-- "+i1.instructor.indexOf(i1.instructor.get(a))+"  ID: "+i1.instructor.get(a));
					}
					
					System.out.print("Select Instructor from the list by selection: ");
					int sel = scn.nextInt();
					String sel1 = i1.instructor.get(sel);
					
					for(int s=i1.instructorclass.indexOf(sel1);s<i1.instructorclass.indexOf(sel1)+2;s++){
						csi1 = i1.instructorclass.get(s);
						csi2 = i1.instructorclass.get(s+1);
					}
					
					System.out.println("\nThe Instructor with ID: '"+sel1+"' teaches this/these classes:");
					
					for(int c=cl1.classList.indexOf(csi1);c<cl1.classList.indexOf(csi1)+1;c++){
						System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
					}
					
					for(int c=cl1.classList.indexOf(csi2);c<cl1.classList.indexOf(csi2)+1;c++){
						System.out.println("Class - Class ID: "+cl1.classList.get(c)+", Name: "+cl1.classList.get(c+1)+", Section ID: "+cl1.classList.get(c+2)+", Days in week: "+cl1.classList.get(c+3));
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