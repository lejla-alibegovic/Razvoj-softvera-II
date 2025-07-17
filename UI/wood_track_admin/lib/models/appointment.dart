import 'package:wood_track_admin/models/service.dart';
import 'package:wood_track_admin/models/user_model.dart';

class Appointment {
  final int id;
  final int clientId;
  late UserModel? client;
  final int employeeId;
  late UserModel? employee;
  final String firstName;
  final String lastName;
  final DateTime birthDate;
  final DateTime dateTime;
  final int serviceId;
  late Service? service;
  final AppointmentStatus status;
  final String? roomNumber;
  final String? location;
  final String? notes;

  Appointment({
    required this.id,
    required this.clientId,
    required this.firstName,
    required this.lastName,
    required this.birthDate,
    required this.employeeId,
    required this.dateTime,
    required this.serviceId,
    required this.status,
    this.roomNumber,
    this.location,
    this.notes,
    this.employee,
    this.client,
    this.service
  });

  factory Appointment.fromJson(Map<String, dynamic> json) {
    return Appointment(
      id: json['id'],
      clientId: json['clientId'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      birthDate: DateTime.parse(json['birthDate']),
      employeeId: json['employeeId'],
      dateTime: DateTime.parse(json['dateTime']),
      serviceId: json['serviceId'],
      service: json['service'] != null ? Service.fromJson(json['service']) : null,
      employee: json['employee'] != null ? UserModel.fromJson(json['employee']) : null,
      status: AppointmentStatus.values.firstWhere(
            (e) => e.index == json['status'],
        orElse: () => AppointmentStatus.Completed,
      ),
      roomNumber: json['roomNumber'],
      location: json['location'],
      notes: json['notes'],
    );
  }

  Map<String, dynamic> toJson() {
    return {
      'id': id,
      'clientId': clientId,
      'firstName': firstName,
      'lastName': lastName,
      'birthDate': birthDate.toIso8601String(),
      'employeeId': employeeId,
      'dateTime': dateTime.toIso8601String(),
      'serviceId': serviceId,
      'status': status.index,
      'roomNumber': roomNumber,
      'location': location,
      'notes': notes,
    };
  }
}

enum AppointmentStatus {
  Scheduled,
  Completed,
  Canceled
}


