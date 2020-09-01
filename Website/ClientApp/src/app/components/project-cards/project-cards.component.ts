import { Component, OnInit, Input } from '@angular/core';
import { ProyectoService } from '../../services/proyecto.service';

@Component({
  selector: 'project-cards',
  templateUrl: './project-cards.component.html',
  styleUrls: ['./project-cards.component.css']
})
export class ProjectCardsComponent implements OnInit {

 @Input() proyectos: any;
 
  constructor(private proyectoService: ProyectoService) { }

  ngOnInit() {
    this.proyectoService.getProyectos().subscribe(data => this.proyectos = data)
  }

}
