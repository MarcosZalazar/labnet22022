import { CategoriesService } from './services/categories.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Category } from './models/category';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  public formCategories!:FormGroup
  public categoriesList: Array<Category>=[];

  constructor(private readonly FormBuild: FormBuilder, private categoriesService:CategoriesService) {}
  
  ngOnInit(): void { 
    this.getCategories();
    this.initForm();
  }

  initForm() {
    this.formCategories=this.FormBuild.group({
      categoryName:['',[Validators.required,Validators.maxLength(15)]],
      description:['',[Validators.required,Validators.maxLength(50)]]
    });
  }

  get f()
  {
    return this.formCategories.controls;   
  }

  saveCategory(){
    var category=new Category();
    category.categoryName=this.formCategories.get('name')!.value;
    category.description=this.formCategories.get('description')!.value;

    this.categoriesService.insertCategory(category).subscribe(res => {
      this.formCategories.reset();
      this.getCategories();
    });
  }
  
  cancelCategory(){
    this.formCategories.reset();
  }

  getCategories(){
    this.categoriesService.getCategories().subscribe(res=>{
      this.categoriesList = res;
    });
  }
}