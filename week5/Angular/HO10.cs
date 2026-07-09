// course-card.component.spec.ts
it('should create', () => { expect(component).toBeTruthy(); });
it('should emit on enroll click', () => {
  spyOn(component.enrollRequested, 'emit');
  // Trigger click logic...
  expect(component.enrollRequested.emit).toHaveBeenCalled();
});