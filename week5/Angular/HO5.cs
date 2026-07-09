// EnrollmentComponent.ts
this.enrollForm = this.fb.group({
  studentName: ['', [Validators.required, Validators.minLength(3)]],
  courseId: [null, [Validators.required, this.noCourseCode]]
});