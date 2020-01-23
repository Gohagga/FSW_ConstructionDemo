import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AsyncValidator } from "@angular/forms";
import { ActivatedRoute, Router } from "@angular/router";
import { first } from 'rxjs/operators';
import { ConstructionService } from '../services/construction-service';
import { TrailExistsValidator } from '../helpers/trail-exists-validator';

@Component({
    selector: 'app-check-trail-exists-component',
    templateUrl: './check-trail-exists.component.html'
})
export class CheckTrailExists implements OnInit {
    trailForm: FormGroup;
    loading = false;
    submitted = false;
    returnUrl: string;
    error: string;
    success: string;

    constructor(
        private formBuilder: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private constructionService: ConstructionService,
        private trailValidator: TrailExistsValidator,
    ) {
    }

    ngOnInit() {
        this.trailForm = this.formBuilder.group({
            trailId: ['', Validators.required, this.trailValidator.checkTrailExists.bind(this.trailValidator)],
        }, {});

        // Get return Url from route parameters or default to '/'
        this.returnUrl = '';//this.route.snapshot.queryParams['returnUrl'] || '/';
    }

    // Convenience getter for easy access to form fields
    get f() { return this.trailForm.controls; }

    onSubmit() {
        this.submitted = true;

        // Stop here if form is invalid
        if (this.trailForm.invalid) {
            return;
        }

        this.loading = true;
    }
}
