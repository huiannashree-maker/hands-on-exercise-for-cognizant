<form #enrollForm='ngForm' (ngSubmit)='onSubmit(enrollForm)'>
  <input name="studentName" ngModel required minlength="3" #nameCtrl="ngModel">
  <span *ngIf="nameCtrl.touched && nameCtrl.errors?.required">Name is required</span>
  <button type="submit" [disabled]="enrollForm.invalid">Submit</button>
</form>