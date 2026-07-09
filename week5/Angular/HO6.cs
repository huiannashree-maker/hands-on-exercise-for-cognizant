// course.service.ts
@Injectable({ providedIn: 'root' })
export class CourseService {
  private courses = [...]; // 5 course objects
  getCourses() { return this.courses; }
}