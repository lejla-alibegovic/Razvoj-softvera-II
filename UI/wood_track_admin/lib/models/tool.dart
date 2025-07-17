import 'package:wood_track_admin/helpers/json_helper.dart';
import 'package:wood_track_admin/models/appUser.dart';
import 'package:wood_track_admin/models/base.dart';
import 'package:wood_track_admin/models/toolCategory.dart';
import 'package:wood_track_admin/models/user_model.dart';

class Tool extends BaseModel {
  late String code;
  late String name;
  late String description;
  late double dimension;
  late DateTime chargedDate;
  late int toolCategoryId;
  late ToolCategory toolCategory;
  late int chargedByUserId;
  late UserModel chargedByUser;

  Tool();

  Tool.fromJson(Map<String, dynamic> json) {
    id = json['id'];
    code = json['code'];
    name = json['name'];
    description = json['description'];
    dimension = json['dimension'];
    chargedDate = json['chargedDate'];
    toolCategoryId = json['toolCategoryId'];
    if (json['toolCategory'] != null) {
      toolCategory = ToolCategory.fromJson(json['toolCategory']);
    }
    chargedByUserId = json['chargedByUserId'];
    if (json['chargedByUser'] != null) {
      chargedByUser = UserModel.fromJson(json['chargedByUser']);
    }
  }

  Map<String, dynamic> toJson() {
    final Map<String, dynamic> data = <String, dynamic>{};
    data['id'] = id;
    data['code'] = code;
    data['name'] = name;
    data['description'] = description;
    data['dimension'] = dimension;
    data['chargedDate'] = chargedDate;
    data['toolCategoryId'] = toolCategoryId;
    data['chargedByUserId'] = chargedByUserId;
    return data;
  }
}
