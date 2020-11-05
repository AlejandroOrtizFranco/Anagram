import { Component } from '@angular/core';
import { ConfigService } from './services/config.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Anagram';

  result:boolean;
  wordString1:string;
  wordString2:string;

  constructor(private service:ConfigService) {}

  callAnagram(){

    let word1: string;
    let word2: string;

    word1=this.wordString1;
    word2=this.wordString2;

    this.service.postAnagram({word1,word2})
      .subscribe(arg => this.result = arg.result);

  }
}
