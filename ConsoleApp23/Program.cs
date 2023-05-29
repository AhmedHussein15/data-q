
6 - write command to retrieve the phone, email of the parent in the
school database whose name is ‘ahmed’.

select phone_number, firs_tname, email_address from parent where firs_tname="ahmed";
----------------------------------------
7 - write command to retrieve the teacher id, subject id of the lesson in
the school database whose lesson id is ‘2’.

select teacher_id, subject_id from lesson where lesson_id=2;
------------------------------------------------------------
8 - write command to retrieve the student id, absence reason of the
attendance in the school database whose attendance id is ‘2’.

select student_id, absencereason_id from attendance where attendance_id=2;
-----------------------------------------------
9 - write command to retrieve the first name, last name of the student
in the school database whose id less than or equal to ‘5’.

select firs_tname, last_name, student_id from student where student_id <=5;
-------------------------------------------------
10 - write command to retrieve the first name, last name of the parent in
the school database whose id not equal to ‘5’ and greater than ‘1’.

select firs_tname, last_name, parent_id from parent where parent_id !=5 and parent_id >1;
---------------------------------------------------
11 - write command to retrieve all information of attendance in the
school database whose absencereasonid is ‘2’ and lesson id is ‘1’.

select from attendance where absencereason_id=2 and lesson_id=1;
--------------------------------------------------------
12 - write command to retrieve lesson id and date of lesson in the
school database whose teacher id is ‘2’ and subject id is ‘4’.
 
select lesson_id, date_lesson, teacher_id, subject_id from lesson where teacher_id=2 and subject_id=4;
---------------------------------------------------------
13 - write command to retrieve all information of student in the school
database whose first name = ‘ahmed’ or parent id is ‘1’.

select * from student where firs_tname="ahmed" and parent_id=1;
-------------------------------------------------------------
14 - write command to retrieve absence reason id, student id of
attendance in the school database whose attendance id = ‘2’ or
lesson id is ‘1’.

select from attendance where absencereason_id=2 and lesson_id=1;
-----------------------------------------------------
15 - Write a command that retrieved the subject id and subject of any
subject in (math1, Ecommerce, ML, math3).

select subject_id, subjectname from subject where subjectname in ("math1","Ecommerce", "ML", "math3");
-------------------------------------------------------------------
16 - Write a command that retrieved the phone, email and first name of
any teacher id in (1, 3, 5).

select phone_number, email address, firs_tname, teacher_id from teacher where teacher_id in(1,3,5);
------------------------------------------------------------------------
17 - Write a command that retrieved the parent id, first name and last
name of parent who inserted phone number.

select parent_id, firs_tname, last_name, phone_number from parent where phone_number is not null;
---------------------------------------------------------------------
18 - Write a command that retrieved the teacher id, first name and last
name of teacher who ignored to insert email address.

select teacher_id, firs_tname, last_name, email_address from teacher where email address is null;
-------------------------------------------------------------------------------------------
19 - Write a command that retrieved the first name, last name of parent
in school database who id in the range 2 and 7.

select firs_tname, last_name, parent_id from parent where parent_id between 2 and 7;
----------------------------------------------------------------------------------
20 - Write a command that retrieved reason of absence reason in school
database whose id in the range 1 and 4.

select reason, absencereason_id from absencereason where absencereason_id between 1 and 4;
----------------------------------------------------------------------------------
21 - Write a command that retrieved the id, first name and last name of
student in school database whose id not in the range 8 and 15. 

select firs_tname, last_name, student_id from student where student_id between 8 and 15;
-------------------------------------------------------------------------------
22 - Write a command to retrieve the subject of subject in the school
database that name start with the character ‘M’.

select subjectname from subject where subjectname like 'MX';
-------------------------------------------------------------------------
23 - Write a command to retrieve the id, first name and phone of
teacher in the school database that name ended with the character
‘A’

select phone_number, firs_tname, teacher_id from teacher where firs_tname like '%A';
------------------------------------------------------------------------------------
24 - Write a command to retrieve the id, first name, phone and email of
parent in the school database that his/her name contains the
character “S”.

select phone_number, firs_tname, email_address from parent where firs_tname like 'X5%';
---------------------------------------------------------------------------------------
25 - Write a command to retrieve the id, first name, phone and email of
parent in the school database that his/her name contains “L” in the
second position. 

select phone_number, firs_tname, email_address, parent_id from parent where firs_tname like '_L%';
--------------------------------------------------------------------------------------
26 - Write a command to retrieve the all id of absence reason id in the
school database using column alies “ID”.

select absencereason_id 'id' from absencereason;
----------------------------------------------------------------
27 - Write a command to retrieve the all frist name, last name of parent
in the school database using columns alies “Full Name”.

select concat(firs_tname, last_name ) as 'full name' from parent;
------------------------------------------------------------------
28 - Write a command to retrieve the all name of absebce reason in the
sales database using table alias “Reasons”.

select reason 'Reason' from absencereason;
-----------------------------------------------------------------
29 - Write a command to retrieve the unique first name of student in the
school database who his/her id in range 1 to 10.

select firs_tname, student_id from student where student_id between 1 and 10;
-----------------------------------------------------------------------
30 - Write a command to retrieve the first three subject in the school
database where subject in (math2, IOT, database, AI).

select subjectname from subject where subjectname in ("math1", "Ecommerce", "ML", "math3") order by subjectname limit 3;
-----------------------------------------------------------
31 - Write a command to retrieve the information of parent in the
school database by the first names ascending.

select * from parent order by firs_tname asc ;
--------------------------------------------------------
32 - Write a command to retrieve the id, first name, email of student in
the school database by the first names descending.

select first_name, student_id from student order by first_name desc ;

-----------------------------------------------------------------------------
33 - Write a command to retrieve the id, first name, last name and email
of teacher in the school database by the first names ascending and id
descending.

select teacher_id, firs_tname, last_name, email address from teacher order by firs_tname asc, teacher_id desc;
-------------------------------------------
34 - Write a command to add new column “degree” in subject table 

alter table subject add degree int;
