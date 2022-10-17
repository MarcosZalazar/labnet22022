import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from '../models/category';
import { throwError as observableThrowError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  public endpoint: string='Categories';

  constructor(private http: HttpClient) { }

  public getCategories(): Observable<Array<any>>{
    let url= environment.apiCategories + this.endpoint;
    return this.http.get<Array<any>>(url);
  }

  public getCategoryById(id:number): Observable<any>{
    let url= environment.apiCategories + this.endpoint+`/${id}`;
    return this.http.get<any>(url);
  }

  public insertCategory(categoryRequest:Category): Observable<any>{
    let url= environment.apiCategories + this.endpoint;
    return this.http.post(url,categoryRequest);
  }

  public updateCategory(id:number, category:Category):Observable<any>{
    let url= environment.apiCategories + this.endpoint+"/"+id;
    return this.http.put<Category>(url, category);
  }

  public deleteCategory(id:number){
    let url= environment.apiCategories + this.endpoint;
    return this.http.delete(url + `/${id}`).pipe(catchError(this.errorHandler));
  }

  errorHandler(error:HttpErrorResponse){
    return observableThrowError(error.message)
  }

}
 