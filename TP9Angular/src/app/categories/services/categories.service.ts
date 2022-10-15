import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Category } from '../models/category';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  public endpoint: string='category';

  constructor(private http: HttpClient) { }

  public insertCategory(categoryRequest:Category): Observable<any>{
    let url= environment.apiCategories + this.endpoint;
    return this.http.post(url,categoryRequest);
  }

  public getCategories(): Observable<Array<any>>{
    let url= environment.apiCategories + this.endpoint;
    return this.http.get<Array<any>>(url);
  }
}
 