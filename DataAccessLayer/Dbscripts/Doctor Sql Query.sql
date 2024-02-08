Create procedure InsertDoctor @Doctorname Nvarchar(100),@DOB DateTime2 ,
@PassedOutYear bigint,@MobileNumber bigint ,@Gender nvarchar
as 
begin
insert into DoctorTablelist values(@Doctorname,@DOB,@PassedOutYear,@MobileNumber,@Gender )
end
go
Create procedure UpadteDoctors @DoctorID bigint, @Doctorname Nvarchar(100),@DOB DateTime2 ,
@PassedOutYear bigint,@MobileNumber bigint ,@Gender nvarchar
as 
begin
update DoctorTablelist set  DoctorName=@Doctorname,DOB=@DOB,PassedOutYear=@PassedOutYear,MobileNumber=@MobileNumber,Gender=@Gender where DoctorID=@DoctorID
end
go
Create Procedure DeleteDoctor @DoctorID bigint
as 
begin
delete DoctorTableList where DoctorID = @DoctorID
end