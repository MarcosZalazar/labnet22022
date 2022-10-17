import { CategoriesService } from './services/categories.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Category } from './models/category';
import { CategoryError } from './models/categoryError';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  public formCategories!:FormGroup
  public categoriesList: Array<Category>=[];
  public categoryError:CategoryError = new CategoryError(400,"");
  public errorMessage:string="";
  public datatable:any = [];
  public submitted:boolean=false;

  constructor(private readonly FormBuild: FormBuilder, private categoriesService:CategoriesService) {}
  
  ngOnInit(): void { 
    this.getCategories();
    this.initForm();
  }

  initForm() {
    this.formCategories=this.FormBuild.group({
      Id:['',Validators.required],
      CategoryName:['',[Validators.required,Validators.maxLength(15)]],
      Description:['', Validators.maxLength(50)]
    });
  }

  onSubmit()
  { 
    this.submitted=true;
    if(this.formCategories.invalid){
      return;
    }
  }

  get f()
  {
    return this.formCategories.controls;   
  }

  saveCategory(){
    var category=new Category();
    category.Id=this.formCategories.get('Id')?.value;
    category.CategoryName=this.formCategories.get('CategoryName')?.value;
    category.Description=this.formCategories.get('Description')?.value;

    if(!category.Id)
    {
      this.categoriesService.insertCategory(category).subscribe(res => {
        this.formCategories.reset();
        this.getCategories();
        alert('Category added successfully');
      });
    }
    else
    {
      this.categoriesService.updateCategory(category.Id,category).subscribe(res => {
        this.formCategories.reset();
        this.getCategories();
        alert('Category modified successfully');
      });
    }
  }
  
  cancelCategory(){
    this.formCategories.reset();
  }

  getCategories(){
    this.categoriesService.getCategories().subscribe(res=>{
      this.categoriesList = res;
    });
  }

  updateCategory(id:number):void{
    if(id!=null){
      const category=this.categoriesList.find(c => c.Id==id);
      if(!category)return;
            
      this.categoriesService.getCategoryById(category.Id).subscribe((result) => {
        Object.keys(this.formCategories.controls).forEach(key =>{
          this.formCategories.controls[key].setValue(result[key]);
        });

        alert('Category information loaded');
      });
    }
  }

  deleteCategory(id:number):void{
    var result=confirm("¿Are you sure you want to delete the category?");
    if(id!=null && result){
      const category=this.categoriesList.find(c => c.Id==id);
      if(!category)return;
            
      this.categoriesService.deleteCategory(category.Id).subscribe({
          next: res =>{
          this.formCategories.reset();
          this.getCategories();
          alert('Category removed successfully');
        },
        error: error => {
          this.errorMessage = error;
          alert(this.errorMessage+"\n\nYou can't delete the category. It's been used by products entity");
        }
      });
    }
  }
}