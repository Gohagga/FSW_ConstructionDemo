import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})
export class ConstructionService {
    private baseUrl: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
    }

    checkTrailExists(id: string) {
        return this.http.get<{result: boolean}>(`${this.baseUrl}api/ExampleConstruction/trail-exists/${id}`);
    }
}
