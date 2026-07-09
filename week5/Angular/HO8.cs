// auth.interceptor.ts
export const authInterceptor: HttpInterceptorFn = (req, next) => {
  const cloned = req.clone({ setHeaders: { Authorization: 'Bearer mock-token-12345' } });
  return next(cloned);
};