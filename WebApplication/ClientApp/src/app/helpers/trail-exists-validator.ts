import { Injectable } from '@angular/core';
import { FormControl } from '@angular/forms';
import { ConstructionService } from '../services/construction-service';

@Injectable({
    providedIn: 'root',
})
export class TrailExistsValidator {

  debouncer: any;

  constructor(public constructionService: ConstructionService){
  }

  checkTrailExists(control: FormControl): any {

    clearTimeout(this.debouncer);

    return new Promise(resolve => {

      this.debouncer = setTimeout(() => {

        this.constructionService.checkTrailExists(control.value).subscribe(data => {
          if(data.result == true){
            resolve(null);
          } else {
            resolve({'notValid': true});
          }
        }, (err) => {
            resolve({'notValid': true});
        });

      }, 1000);

    });
  }

}