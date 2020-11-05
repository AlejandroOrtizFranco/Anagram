import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Anagram } from '../models/anagram';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  constructor(private http:HttpClient) { }

  postAnagram(anagram:Anagram): Observable<any>{
    return this.http.post<any>("https://localhost:44309/api/anagram",anagram);
  }
}
