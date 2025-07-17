import 'package:wood_track_admin/providers/base_provider.dart';
import '../models/appConfig.dart';

class AppConfigsProvider extends BaseProvider<AppConfig> {
  AppConfigsProvider() : super('AppConfigs');

  @override
  AppConfig fromJson(data) {
    return AppConfig.fromJson(data);
  }
}