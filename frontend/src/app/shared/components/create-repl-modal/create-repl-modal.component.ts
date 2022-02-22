import {Component, OnInit, ViewChild} from '@angular/core';
import {NgbActiveModal, NgbTypeahead} from "@ng-bootstrap/ng-bootstrap";
import {debounceTime, distinctUntilChanged, filter, map, merge, Observable, OperatorFunction, Subject} from "rxjs";

const templates = ['Clojure', 'Haskell', 'Kotlin', 'QBasic', 'Forth', 'LOLCODE', 'BrainF', 'Emoticon', 'Bloop', 'Unlambda',
  'CoffeeScript', 'Scheme', 'APL', 'Lua', 'Ruby', 'Roy', 'Python', 'Node.js', 'Deno (beta)', 'Golang', 'C++', 'C', 'C#',
'F#', 'HTML', 'CSS', 'JS', 'Rust', 'Swift', 'Python', 'Basic (beta)', 'R', 'Bash', 'Crystal', 'Julia', 'Elixir', 'Nim', 'Dart',
'Reason Node.js', 'Tcl', 'Erlang', 'TypeScript', 'Pygame', 'Love2D', 'Emacs Lisp (Elisp)', 'PHP Web Server', 'SQLite', 'Java',
  'PHP CLI', 'Pyxel', 'Raku', 'Scala (beta)', 'Nix (beta)', 'JavaScript'];

@Component({
  templateUrl: './create-repl-modal.component.html',
  styleUrls: ['./create-repl-modal.component.sass']
})
export class CreateReplModalComponent implements OnInit {

  model: any;
  @ViewChild('instance', {static: true}) instance: NgbTypeahead;
  focus$ = new Subject<string>();
  click$ = new Subject<string>();

  constructor(public activeModal: NgbActiveModal) {}

  ngOnInit(): void {
  }
  search: OperatorFunction<string, readonly string[]> = (text$: Observable<string>) => {
    const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
    const clicksWithClosedPopup$ = this.click$.pipe(filter(() => !this.instance.isPopupOpen()));
    const inputFocus$ = this.focus$;
    return merge(debouncedText$, inputFocus$, clicksWithClosedPopup$).pipe(
      map(term => (term === '' ? templates
        : templates.filter(v => v.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 100))
    );
  }

}
