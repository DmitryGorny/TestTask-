import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { UsersService } from '../../services/users.service';
import { User } from '../../models/user.model';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  standalone: false
})
export class UsersComponent implements OnInit {
  users: User[] = [];
  isLoading = false;
  error = '';

  constructor(
    private usersService: UsersService,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit(): void {
    this.loadUsers();
  }

  loadUsers(): void {
    this.isLoading = true;
    this.error = '';

    this.usersService.getUsers().subscribe({
      next: (data) => {
        this.users = data;
        this.isLoading = false;
        this.cdr.detectChanges();
      },
      error: () => {
        this.error = 'Не удалось загрузить данные';
        this.isLoading = false;
        this.cdr.detectChanges();
      },
    });
  }
}