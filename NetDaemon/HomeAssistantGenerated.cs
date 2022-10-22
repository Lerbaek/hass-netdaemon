using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		GroupEntities Group { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersonEntities Person { get; }

		ScriptEntities Script { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		UpdateEntities Update { get; }

		VacuumEntities Vacuum { get; }

		VarEntities Var { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public GroupEntities Group => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public VarEntities Var => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Renovation: Indiker deadline</summary>
		public AutomationEntity AlarmRenovation => new(_haContext, "automation.alarm_renovation");
		///<summary>Badeværelse: Dæmpet lys om natten</summary>
		public AutomationEntity BadevaerelseDaempetLysOmNatten => new(_haContext, "automation.badevaerelse_daempet_lys_om_natten");
		///<summary>Bil: Automatisk lås</summary>
		public AutomationEntity BilAutomatiskLas => new(_haContext, "automation.bil_automatisk_las");
		///<summary>Bil: Advarsel ved manglende opladning</summary>
		public AutomationEntity BilenBurdeLade => new(_haContext, "automation.bilen_burde_lade");
		///<summary>Bilopladning: Retry</summary>
		public AutomationEntity BilopladningRetry => new(_haContext, "automation.bilopladning_retry");
		///<summary>Bryggers: TS004F</summary>
		public AutomationEntity BryggersKontaktMedFireKnapper => new(_haContext, "automation.bryggers_kontakt_med_fire_knapper");
		///<summary>Dørklokke</summary>
		public AutomationEntity Dorklokke => new(_haContext, "automation.dorklokke");
		///<summary>Ebbe: Åbent vindue, stop radiator</summary>
		public AutomationEntity EbbeAbentVindueStopRadiator => new(_haContext, "automation.ebbe_abent_vindue_stop_radiator");
		///<summary>Garage: Åben</summary>
		public AutomationEntity GarageAben => new(_haContext, "automation.garage_aben");
		///<summary>Garage: Lukket</summary>
		public AutomationEntity GarageLukket => new(_haContext, "automation.garage_lukket");
		///<summary>Garage: Toggle</summary>
		public AutomationEntity GarageToggle => new(_haContext, "automation.garage_toggle");
		///<summary>Grasputin: Kør afbrudt</summary>
		public AutomationEntity GrasputinKorAfbrudtIEtDogn => new(_haContext, "automation.grasputin_kor_afbrudt_i_et_dogn");
		///<summary>Hjem: Ferietilstand</summary>
		public AutomationEntity HjemFerietilstand => new(_haContext, "automation.hjem_ferietilstand");
		///<summary>Hjem: Night mode</summary>
		public AutomationEntity HjemNightMode => new(_haContext, "automation.hjem_night_mode");
		///<summary>Julelys: Sluk</summary>
		public AutomationEntity JulelysSluk => new(_haContext, "automation.julelys_sluk");
		///<summary>Julelys: Tænd</summary>
		public AutomationEntity JulelysTaend => new(_haContext, "automation.julelys_taend");
		///<summary>Køkken: Afbryder, underskabsbelysning</summary>
		public AutomationEntity KokkenAfbryderUnderskabsbelysning => new(_haContext, "automation.kokken_afbryder_underskabsbelysning");
		///<summary>Køkken: Afbryder, underskabsbelysning</summary>
		public AutomationEntity KokkenAfbryderUnderskabsbelysning2 => new(_haContext, "automation.kokken_afbryder_underskabsbelysning_2");
		///<summary>Køkken: Underskabsbelysning</summary>
		public AutomationEntity KokkenUnderskabsbelysning => new(_haContext, "automation.kokken_underskabsbelysning");
		///<summary>Kummefryser: Strømafbrydelse</summary>
		public AutomationEntity Kummefryser => new(_haContext, "automation.kummefryser");
		///<summary>Low battery level detection & notification for all battery sensors</summary>
		public AutomationEntity LowBatteryLevelDetectionNotificationForAllBatterySensors => new(_haContext, "automation.low_battery_level_detection_notification_for_all_battery_sensors");
		///<summary>Motion-activated Light</summary>
		public AutomationEntity MotionActivatedLight => new(_haContext, "automation.motion_activated_light");
		///<summary>Stue: Motion sensor</summary>
		public AutomationEntity MotionSensorLysIStuen => new(_haContext, "automation.motion_sensor_lys_i_stuen");
		///<summary>Hjem: Ingen hjemme</summary>
		public AutomationEntity NewAutomation => new(_haContext, "automation.new_automation");
		///<summary>Renovation: Alarm</summary>
		public AutomationEntity RenovationAlarm => new(_haContext, "automation.renovation_alarm");
		///<summary>Renovation: Overskredet deadline</summary>
		public AutomationEntity RenovationOverskredetDeadline => new(_haContext, "automation.renovation_overskredet_deadline");
		///<summary>Roar: Åbent vindue, stop radiator</summary>
		public AutomationEntity RoarAbentVindueStopRadiator => new(_haContext, "automation.roar_abent_vindue_stop_radiator");
		///<summary>Roar: Dæmp lyset om natten</summary>
		public AutomationEntity RoarDaempLysetOmNatten => new(_haContext, "automation.roar_daemp_lyset_om_natten");
		///<summary>Roar: Sluk lyset om morgenen</summary>
		public AutomationEntity RoarSlukLysetOmMorgenen => new(_haContext, "automation.roar_sluk_lyset_om_morgenen");
		///<summary>Roar: Sluk lyset under sengen om natten</summary>
		public AutomationEntity RoarSlukLysetUnderSengenOmNatten => new(_haContext, "automation.roar_sluk_lyset_under_sengen_om_natten");
		///<summary>Roar: Tænd natlys</summary>
		public AutomationEntity RoarTaendNatlys => new(_haContext, "automation.roar_taend_natlys");
		///<summary>Seedbox: Advarsel ved manglende strøm</summary>
		public AutomationEntity SeedboxOffline => new(_haContext, "automation.seedbox_offline");
		///<summary>Loft: Sluk lyset efter en time</summary>
		public AutomationEntity SlukLysetPaLoftetEfterEnTime => new(_haContext, "automation.sluk_lyset_pa_loftet_efter_en_time");
		///<summary>Støvsuger: TS004F</summary>
		public AutomationEntity StovsugerTs004f => new(_haContext, "automation.stovsuger_ts004f");
		///<summary>Stue: Åben dør, stop radiatorer</summary>
		public AutomationEntity StueAbenDorStopRadiatorer => new(_haContext, "automation.stue_aben_dor_stop_radiatorer");
		///<summary>Stue: Nulstil natlys om morgenen</summary>
		public AutomationEntity StueNulstilNatlysOmMorgenen => new(_haContext, "automation.stue_nulstil_natlys_om_morgenen");
		///<summary>Stue: TS004F</summary>
		public AutomationEntity StueTs004f => new(_haContext, "automation.stue_ts004f");
		///<summary>Terrasse: Sluk lys ved sengetid</summary>
		public AutomationEntity TerrasseSlukLysVedSengetid => new(_haContext, "automation.terrasse_sluk_lys_ved_sengetid");
		///<summary>Ude: Sluk alle lys ved solopgang</summary>
		public AutomationEntity UdeSlukAlleLysVedSolopgang => new(_haContext, "automation.ude_sluk_alle_lys_ved_solopgang");
		///<summary>Walk-in closet: E1812 TRÅDFRI Shortcut button</summary>
		public AutomationEntity WalkInClosetE1812TradfriShortcutButton => new(_haContext, "automation.walk_in_closet_e1812_tradfri_shortcut_button");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse early start</summary>
		public BinarySensorEntity BadevaerelseEarlyStart => new(_haContext, "binary_sensor.badevaerelse_early_start");
		///<summary>Badeværelse link</summary>
		public BinarySensorEntity BadevaerelseLink => new(_haContext, "binary_sensor.badevaerelse_link");
		///<summary>Badeværelse open window</summary>
		public BinarySensorEntity BadevaerelseOpenWindow => new(_haContext, "binary_sensor.badevaerelse_open_window");
		///<summary>Badeværelse overlay</summary>
		public BinarySensorEntity BadevaerelseOverlay => new(_haContext, "binary_sensor.badevaerelse_overlay");
		///<summary>Badeværelse power</summary>
		public BinarySensorEntity BadevaerelsePower => new(_haContext, "binary_sensor.badevaerelse_power");
		///<summary>Ballon update available</summary>
		public BinarySensorEntity BallonUpdateAvailable => new(_haContext, "binary_sensor.ballon_update_available");
		///<summary>Bevægelse i stuen battery low</summary>
		public BinarySensorEntity BevaegelseIStuenBatteryLow => new(_haContext, "binary_sensor.bevaegelse_i_stuen_battery_low");
		///<summary>Bevægelse i stuen occupancy</summary>
		public BinarySensorEntity BevaegelseIStuenOccupancy => new(_haContext, "binary_sensor.bevaegelse_i_stuen_occupancy");
		///<summary>Bevægelse i stuen tamper</summary>
		public BinarySensorEntity BevaegelseIStuenTamper => new(_haContext, "binary_sensor.bevaegelse_i_stuen_tamper");
		///<summary>Bryggers update available</summary>
		public BinarySensorEntity BryggersUpdateAvailable => new(_haContext, "binary_sensor.bryggers_update_available");
		///<summary>CEED Air Conditioner</summary>
		public BinarySensorEntity CeedAirConditioner => new(_haContext, "binary_sensor.ceed_air_conditioner");
		///<summary>CEED Back Window Heater</summary>
		public BinarySensorEntity CeedBackWindowHeater => new(_haContext, "binary_sensor.ceed_back_window_heater");
		///<summary>CEED Charging</summary>
		public BinarySensorEntity CeedCharging => new(_haContext, "binary_sensor.ceed_charging");
		///<summary>CEED Data</summary>
		public BinarySensorEntity CeedData => new(_haContext, "binary_sensor.ceed_data");
		///<summary>CEED Defroster</summary>
		public BinarySensorEntity CeedDefroster => new(_haContext, "binary_sensor.ceed_defroster");
		///<summary>CEED Door - Front Left</summary>
		public BinarySensorEntity CeedDoorFrontLeft => new(_haContext, "binary_sensor.ceed_door_front_left");
		///<summary>CEED Door - Front Right</summary>
		public BinarySensorEntity CeedDoorFrontRight => new(_haContext, "binary_sensor.ceed_door_front_right");
		///<summary>CEED Door - Rear Left</summary>
		public BinarySensorEntity CeedDoorRearLeft => new(_haContext, "binary_sensor.ceed_door_rear_left");
		///<summary>CEED Door - Rear Right</summary>
		public BinarySensorEntity CeedDoorRearRight => new(_haContext, "binary_sensor.ceed_door_rear_right");
		///<summary>CEED Engine</summary>
		public BinarySensorEntity CeedEngine => new(_haContext, "binary_sensor.ceed_engine");
		///<summary>CEED Hood</summary>
		public BinarySensorEntity CeedHood => new(_haContext, "binary_sensor.ceed_hood");
		///<summary>CEED Low Fuel Light</summary>
		public BinarySensorEntity CeedLowFuelLight => new(_haContext, "binary_sensor.ceed_low_fuel_light");
		///<summary>CEED Plugged In</summary>
		public BinarySensorEntity CeedPluggedIn => new(_haContext, "binary_sensor.ceed_plugged_in");
		///<summary>CEED Steering Wheel Heater</summary>
		public BinarySensorEntity CeedSteeringWheelHeater => new(_haContext, "binary_sensor.ceed_steering_wheel_heater");
		///<summary>CEED Tire Pressure - All</summary>
		public BinarySensorEntity CeedTirePressureAll => new(_haContext, "binary_sensor.ceed_tire_pressure_all");
		///<summary>CEED Tire Pressure - Front Left</summary>
		public BinarySensorEntity CeedTirePressureFrontLeft => new(_haContext, "binary_sensor.ceed_tire_pressure_front_left");
		///<summary>CEED Tire Pressure - Front Right</summary>
		public BinarySensorEntity CeedTirePressureFrontRight => new(_haContext, "binary_sensor.ceed_tire_pressure_front_right");
		///<summary>CEED Tire Pressure - Rear Left</summary>
		public BinarySensorEntity CeedTirePressureRearLeft => new(_haContext, "binary_sensor.ceed_tire_pressure_rear_left");
		///<summary>CEED Tire Pressure - Rear Right</summary>
		public BinarySensorEntity CeedTirePressureRearRight => new(_haContext, "binary_sensor.ceed_tire_pressure_rear_right");
		///<summary>CEED Trunk</summary>
		public BinarySensorEntity CeedTrunk => new(_haContext, "binary_sensor.ceed_trunk");
		///<summary>Dør: Stue contact</summary>
		public BinarySensorEntity DorStueContact => new(_haContext, "binary_sensor.dor_stue_contact");
		///<summary>Flowerpot VP1 update available</summary>
		public BinarySensorEntity FlowerpotVp1UpdateAvailable => new(_haContext, "binary_sensor.flowerpot_vp1_update_available");
		///<summary>Garage-lanterne update available</summary>
		public BinarySensorEntity GarageLanterneUpdateAvailable => new(_haContext, "binary_sensor.garage_lanterne_update_available");
		///<summary>Garagedør-sensor battery low</summary>
		public BinarySensorEntity GaragedorSensorBatteryLow => new(_haContext, "binary_sensor.garagedor_sensor_battery_low");
		///<summary>Garagedør-sensor contact</summary>
		public BinarySensorEntity GaragedorSensorContact => new(_haContext, "binary_sensor.garagedor_sensor_contact");
		///<summary>Garageport-knap, bil update available</summary>
		public BinarySensorEntity GarageportKnapBilUpdateAvailable => new(_haContext, "binary_sensor.garageport_knap_bil_update_available");
		///<summary>Gros Galaxy S20+ High Accuracy Mode</summary>
		public BinarySensorEntity GrosGalaxyS20HighAccuracyMode => new(_haContext, "binary_sensor.gros_galaxy_s20_high_accuracy_mode");
		///<summary>Gros Galaxy S20+ Is Charging</summary>
		public BinarySensorEntity GrosGalaxyS20IsCharging => new(_haContext, "binary_sensor.gros_galaxy_s20_is_charging");
		///<summary>IB3356497408 connection state</summary>
		public BinarySensorEntity Ib3356497408ConnectionState => new(_haContext, "binary_sensor.ib3356497408_connection_state");
		///<summary>Kanin-astronaut update available</summary>
		public BinarySensorEntity KaninAstronautUpdateAvailable => new(_haContext, "binary_sensor.kanin_astronaut_update_available");
		///<summary>Køkken / Gang early start</summary>
		public BinarySensorEntity KokkenGangEarlyStart => new(_haContext, "binary_sensor.kokken_gang_early_start");
		///<summary>Køkken / Gang link</summary>
		public BinarySensorEntity KokkenGangLink => new(_haContext, "binary_sensor.kokken_gang_link");
		///<summary>Køkken / Gang open window</summary>
		public BinarySensorEntity KokkenGangOpenWindow => new(_haContext, "binary_sensor.kokken_gang_open_window");
		///<summary>Køkken / Gang overlay</summary>
		public BinarySensorEntity KokkenGangOverlay => new(_haContext, "binary_sensor.kokken_gang_overlay");
		///<summary>Køkken / Gang power</summary>
		public BinarySensorEntity KokkenGangPower => new(_haContext, "binary_sensor.kokken_gang_power");
		///<summary>Køkkenvask-kontakt update available</summary>
		public BinarySensorEntity KokkenvaskKontaktUpdateAvailable => new(_haContext, "binary_sensor.kokkenvask_kontakt_update_available");
		///<summary>Kristoffers Galaxy S20 Ultra Device Locked</summary>
		public BinarySensorEntity KristoffersGalaxyS20UltraDeviceLocked => new(_haContext, "binary_sensor.kristoffers_galaxy_s20_ultra_device_locked");
		///<summary>Kristoffers Galaxy S20 Ultra Interactive</summary>
		public BinarySensorEntity KristoffersGalaxyS20UltraInteractive => new(_haContext, "binary_sensor.kristoffers_galaxy_s20_ultra_interactive");
		///<summary>Kristoffers Galaxy S20 Ultra Is Charging</summary>
		public BinarySensorEntity KristoffersGalaxyS20UltraOplader => new(_haContext, "binary_sensor.kristoffers_galaxy_s20_ultra_oplader");
		///<summary>Ebbes værelse early start</summary>
		public BinarySensorEntity LillebrorsVaerelseEarlyStart => new(_haContext, "binary_sensor.lillebrors_vaerelse_early_start");
		///<summary>Ebbes værelse link</summary>
		public BinarySensorEntity LillebrorsVaerelseLink => new(_haContext, "binary_sensor.lillebrors_vaerelse_link");
		///<summary>Ebbes værelse open window</summary>
		public BinarySensorEntity LillebrorsVaerelseOpenWindow => new(_haContext, "binary_sensor.lillebrors_vaerelse_open_window");
		///<summary>Ebbes værelse overlay</summary>
		public BinarySensorEntity LillebrorsVaerelseOverlay => new(_haContext, "binary_sensor.lillebrors_vaerelse_overlay");
		///<summary>Ebbes værelse power</summary>
		public BinarySensorEntity LillebrorsVaerelsePower => new(_haContext, "binary_sensor.lillebrors_vaerelse_power");
		///<summary>nextcloud_system_debug</summary>
		public BinarySensorEntity NextcloudSystemDebug => new(_haContext, "binary_sensor.nextcloud_system_debug");
		///<summary>nextcloud_system_enable_avatars</summary>
		public BinarySensorEntity NextcloudSystemEnableAvatars => new(_haContext, "binary_sensor.nextcloud_system_enable_avatars");
		///<summary>nextcloud_system_enable_previews</summary>
		public BinarySensorEntity NextcloudSystemEnablePreviews => new(_haContext, "binary_sensor.nextcloud_system_enable_previews");
		///<summary>nextcloud_system_filelocking.enabled</summary>
		public BinarySensorEntity NextcloudSystemFilelockingEnabled => new(_haContext, "binary_sensor.nextcloud_system_filelocking_enabled");
		///<summary>olive_tree_branch_state</summary>
		public BinarySensorEntity OliveTreeBranchState => new(_haContext, "binary_sensor.olive_tree_branch_state");
		///<summary>Partial: Aläng 1 update available</summary>
		public BinarySensorEntity PartialAlang1UpdateAvailable => new(_haContext, "binary_sensor.partial_alang_1_update_available");
		///<summary>Partial: Aläng 2 update available</summary>
		public BinarySensorEntity PartialAlang2UpdateAvailable => new(_haContext, "binary_sensor.partial_alang_2_update_available");
		///<summary>Partial: Aläng 3 update available</summary>
		public BinarySensorEntity PartialAlang3UpdateAvailable => new(_haContext, "binary_sensor.partial_alang_3_update_available");
		///<summary>Partial: Badeværelse GU5.3 Bad update available</summary>
		public BinarySensorEntity PartialBadevaerelseGu53BadUpdateAvailable => new(_haContext, "binary_sensor.partial_badevaerelse_gu5_3_bad_update_available");
		///<summary>Partial: Badeværelse GU5.3 Midt update available</summary>
		public BinarySensorEntity PartialBadevaerelseGu53MidtUpdateAvailable => new(_haContext, "binary_sensor.partial_badevaerelse_gu5_3_midt_update_available");
		///<summary>Partial: Badeværelse GU5.3 Toilet update available</summary>
		public BinarySensorEntity PartialBadevaerelseGu53ToiletUpdateAvailable => new(_haContext, "binary_sensor.partial_badevaerelse_gu5_3_toilet_update_available");
		///<summary>Partial: Felena Tassel RGBW 1 update available</summary>
		public BinarySensorEntity PartialFelenaTasselRgbw1UpdateAvailable => new(_haContext, "binary_sensor.partial_felena_tassel_rgbw_1_update_available");
		///<summary>Partial: Felena Tassel RGBW 2 update available</summary>
		public BinarySensorEntity PartialFelenaTasselRgbw2UpdateAvailable => new(_haContext, "binary_sensor.partial_felena_tassel_rgbw_2_update_available");
		///<summary>Partial: Felena Tassel RGBW 3 update available</summary>
		public BinarySensorEntity PartialFelenaTasselRgbw3UpdateAvailable => new(_haContext, "binary_sensor.partial_felena_tassel_rgbw_3_update_available");
		///<summary>Partial: Køkkenvask 1 update available</summary>
		public BinarySensorEntity PartialKokkenvask1UpdateAvailable => new(_haContext, "binary_sensor.partial_kokkenvask_1_update_available");
		///<summary>Partial: Køkkenvask 2 update available</summary>
		public BinarySensorEntity PartialKokkenvask2UpdateAvailable => new(_haContext, "binary_sensor.partial_kokkenvask_2_update_available");
		///<summary>Partial: Køkkenvask 3 update available</summary>
		public BinarySensorEntity PartialKokkenvask3UpdateAvailable => new(_haContext, "binary_sensor.partial_kokkenvask_3_update_available");
		///<summary>Partial: Toilet (dør) update available</summary>
		public BinarySensorEntity PartialToiletDorUpdateAvailable => new(_haContext, "binary_sensor.partial_toilet_dor_update_available");
		///<summary>Partial: Toilet (vindue) update available</summary>
		public BinarySensorEntity PartialToiletVindueUpdateAvailable => new(_haContext, "binary_sensor.partial_toilet_vindue_update_available");
		///<summary>Renovation</summary>
		public BinarySensorEntity Renovation => new(_haContext, "binary_sensor.renovation");
		///<summary>Roars værelse early start</summary>
		public BinarySensorEntity RoarsVaerelseEarlyStart => new(_haContext, "binary_sensor.roars_vaerelse_early_start");
		///<summary>Roars værelse link</summary>
		public BinarySensorEntity RoarsVaerelseLink => new(_haContext, "binary_sensor.roars_vaerelse_link");
		///<summary>Roars værelse open window</summary>
		public BinarySensorEntity RoarsVaerelseOpenWindow => new(_haContext, "binary_sensor.roars_vaerelse_open_window");
		///<summary>Roars værelse overlay</summary>
		public BinarySensorEntity RoarsVaerelseOverlay => new(_haContext, "binary_sensor.roars_vaerelse_overlay");
		///<summary>Roars værelse power</summary>
		public BinarySensorEntity RoarsVaerelsePower => new(_haContext, "binary_sensor.roars_vaerelse_power");
		///<summary>Roborock S5 Max Mop attached</summary>
		public BinarySensorEntity RoborockS5MaxMopAttached => new(_haContext, "binary_sensor.roborock_s5_max_mop_attached");
		///<summary>Roborock S5 Max Water box attached</summary>
		public BinarySensorEntity RoborockS5MaxWaterBoxAttached => new(_haContext, "binary_sensor.roborock_s5_max_water_box_attached");
		///<summary>RPi Power status</summary>
		public BinarySensorEntity RpiPowerStatus => new(_haContext, "binary_sensor.rpi_power_status");
		///<summary>RU0667616768 battery state</summary>
		public BinarySensorEntity Ru0667616768BatteryState => new(_haContext, "binary_sensor.ru0667616768_battery_state");
		///<summary>RU0667616768 connection state</summary>
		public BinarySensorEntity Ru0667616768ConnectionState => new(_haContext, "binary_sensor.ru0667616768_connection_state");
		///<summary>Samsung CLP-325W</summary>
		public BinarySensorEntity SamsungClp325w => new(_haContext, "binary_sensor.samsung_clp_325w");
		///<summary>Samsung CLP-325W</summary>
		public BinarySensorEntity SamsungClp325w2 => new(_haContext, "binary_sensor.samsung_clp_325w_2");
		///<summary>Soveværelse early start</summary>
		public BinarySensorEntity SovevaerelseEarlyStart => new(_haContext, "binary_sensor.sovevaerelse_early_start");
		///<summary>Soveværelse link</summary>
		public BinarySensorEntity SovevaerelseLink => new(_haContext, "binary_sensor.sovevaerelse_link");
		///<summary>Soveværelse open window</summary>
		public BinarySensorEntity SovevaerelseOpenWindow => new(_haContext, "binary_sensor.sovevaerelse_open_window");
		///<summary>Soveværelse overlay</summary>
		public BinarySensorEntity SovevaerelseOverlay => new(_haContext, "binary_sensor.sovevaerelse_overlay");
		///<summary>Soveværelse power</summary>
		public BinarySensorEntity SovevaerelsePower => new(_haContext, "binary_sensor.sovevaerelse_power");
		///<summary>Stue early start</summary>
		public BinarySensorEntity StueEarlyStart => new(_haContext, "binary_sensor.stue_early_start");
		///<summary>Stue link</summary>
		public BinarySensorEntity StueLink => new(_haContext, "binary_sensor.stue_link");
		///<summary>Stue open window</summary>
		public BinarySensorEntity StueOpenWindow => new(_haContext, "binary_sensor.stue_open_window");
		///<summary>Stue overlay</summary>
		public BinarySensorEntity StueOverlay => new(_haContext, "binary_sensor.stue_overlay");
		///<summary>Stue power</summary>
		public BinarySensorEntity StuePower => new(_haContext, "binary_sensor.stue_power");
		///<summary>Toilet early start</summary>
		public BinarySensorEntity ToiletEarlyStart => new(_haContext, "binary_sensor.toilet_early_start");
		///<summary>Toilet link</summary>
		public BinarySensorEntity ToiletLink => new(_haContext, "binary_sensor.toilet_link");
		///<summary>Toilet open window</summary>
		public BinarySensorEntity ToiletOpenWindow => new(_haContext, "binary_sensor.toilet_open_window");
		///<summary>Toilet overlay</summary>
		public BinarySensorEntity ToiletOverlay => new(_haContext, "binary_sensor.toilet_overlay");
		///<summary>Toilet power</summary>
		public BinarySensorEntity ToiletPower => new(_haContext, "binary_sensor.toilet_power");
		///<summary>Underskabsbelysning-kontakt update available</summary>
		public BinarySensorEntity UnderskabsbelysningKontaktUpdateAvailable => new(_haContext, "binary_sensor.underskabsbelysning_kontakt_update_available");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
		///<summary>VA0006690304 battery state</summary>
		public BinarySensorEntity Va0006690304BatteryState => new(_haContext, "binary_sensor.va0006690304_battery_state");
		///<summary>VA0006690304 connection state</summary>
		public BinarySensorEntity Va0006690304ConnectionState => new(_haContext, "binary_sensor.va0006690304_connection_state");
		///<summary>VA0203691776 battery state</summary>
		public BinarySensorEntity Va0203691776BatteryState => new(_haContext, "binary_sensor.va0203691776_battery_state");
		///<summary>VA0203691776 connection state</summary>
		public BinarySensorEntity Va0203691776ConnectionState => new(_haContext, "binary_sensor.va0203691776_connection_state");
		///<summary>VA0292559360 battery state</summary>
		public BinarySensorEntity Va0292559360BatteryState => new(_haContext, "binary_sensor.va0292559360_battery_state");
		///<summary>VA0292559360 connection state</summary>
		public BinarySensorEntity Va0292559360ConnectionState => new(_haContext, "binary_sensor.va0292559360_connection_state");
		///<summary>VA0846141952 battery state</summary>
		public BinarySensorEntity Va0846141952BatteryState => new(_haContext, "binary_sensor.va0846141952_battery_state");
		///<summary>VA0846141952 connection state</summary>
		public BinarySensorEntity Va0846141952ConnectionState => new(_haContext, "binary_sensor.va0846141952_connection_state");
		///<summary>VA1555305984 battery state</summary>
		public BinarySensorEntity Va1555305984BatteryState => new(_haContext, "binary_sensor.va1555305984_battery_state");
		///<summary>VA1555305984 connection state</summary>
		public BinarySensorEntity Va1555305984ConnectionState => new(_haContext, "binary_sensor.va1555305984_connection_state");
		///<summary>VA2289048064 battery state</summary>
		public BinarySensorEntity Va2289048064BatteryState => new(_haContext, "binary_sensor.va2289048064_battery_state");
		///<summary>VA2289048064 connection state</summary>
		public BinarySensorEntity Va2289048064ConnectionState => new(_haContext, "binary_sensor.va2289048064_connection_state");
		///<summary>VA2590972416 battery state</summary>
		public BinarySensorEntity Va2590972416BatteryState => new(_haContext, "binary_sensor.va2590972416_battery_state");
		///<summary>VA2590972416 connection state</summary>
		public BinarySensorEntity Va2590972416ConnectionState => new(_haContext, "binary_sensor.va2590972416_connection_state");
		///<summary>VA2708412928 battery state</summary>
		public BinarySensorEntity Va2708412928BatteryState => new(_haContext, "binary_sensor.va2708412928_battery_state");
		///<summary>VA2708412928 connection state</summary>
		public BinarySensorEntity Va2708412928ConnectionState => new(_haContext, "binary_sensor.va2708412928_connection_state");
		///<summary>VA2792299008 battery state</summary>
		public BinarySensorEntity Va2792299008BatteryState => new(_haContext, "binary_sensor.va2792299008_battery_state");
		///<summary>VA2792299008 connection state</summary>
		public BinarySensorEntity Va2792299008ConnectionState => new(_haContext, "binary_sensor.va2792299008_connection_state");
		///<summary>VA3228506624 battery state</summary>
		public BinarySensorEntity Va3228506624BatteryState => new(_haContext, "binary_sensor.va3228506624_battery_state");
		///<summary>VA3228506624 connection state</summary>
		public BinarySensorEntity Va3228506624ConnectionState => new(_haContext, "binary_sensor.va3228506624_connection_state");
		///<summary>VA3396213248 battery state</summary>
		public BinarySensorEntity Va3396213248BatteryState => new(_haContext, "binary_sensor.va3396213248_battery_state");
		///<summary>VA3396213248 connection state</summary>
		public BinarySensorEntity Va3396213248ConnectionState => new(_haContext, "binary_sensor.va3396213248_connection_state");
		///<summary>Valder update available</summary>
		public BinarySensorEntity ValderUpdateAvailable => new(_haContext, "binary_sensor.valder_update_available");
		///<summary>Vindue: Ebbe contact</summary>
		public BinarySensorEntity VindueEbbeContact => new(_haContext, "binary_sensor.vindue_ebbe_contact");
		///<summary>Vindue: Roar contact</summary>
		public BinarySensorEntity VindueRoarContact => new(_haContext, "binary_sensor.vindue_roar_contact");
		///<summary>Vinke-astronaut update available</summary>
		public BinarySensorEntity VinkeAstronautUpdateAvailable => new(_haContext, "binary_sensor.vinke_astronaut_update_available");
		///<summary>Walk-in-closet-kontakt update available</summary>
		public BinarySensorEntity WalkInClosetKontaktUpdateAvailable => new(_haContext, "binary_sensor.walk_in_closet_kontakt_update_available");
		///<summary>Walk-in closet update available</summary>
		public BinarySensorEntity WalkInClosetUpdateAvailable => new(_haContext, "binary_sensor.walk_in_closet_update_available");
		///<summary>XR500 (Gateway) wan status</summary>
		public BinarySensorEntity Xr500GatewayWanStatus => new(_haContext, "binary_sensor.xr500_gateway_wan_status");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Scan Clients (Seedbox)</summary>
		public ButtonEntity ScanClientsSeedbox => new(_haContext, "button.scan_clients_seedbox");
		///<summary>Synchronize Devices</summary>
		public ButtonEntity SynchronizeDevices => new(_haContext, "button.synchronize_devices");
		///<summary>XR500 Reboot</summary>
		public ButtonEntity Xr500Reboot => new(_haContext, "button.xr500_reboot");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Nest Hello (hoveddør)</summary>
		public CameraEntity NestHelloHoveddor => new(_haContext, "camera.nest_hello_hoveddor");
		///<summary>Xiaomi Cloud Map Extractor</summary>
		public CameraEntity XiaomiCloudMapExtractor => new(_haContext, "camera.xiaomi_cloud_map_extractor");
	}

	public partial class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse</summary>
		public ClimateEntity Badevaerelse => new(_haContext, "climate.badevaerelse");
		///<summary>Køkken / Gang</summary>
		public ClimateEntity KokkenGang => new(_haContext, "climate.kokken_gang");
		///<summary>Ebbes værelse</summary>
		public ClimateEntity LillebrorsVaerelse => new(_haContext, "climate.lillebrors_vaerelse");
		///<summary>Roars værelse</summary>
		public ClimateEntity RoarsVaerelse => new(_haContext, "climate.roars_vaerelse");
		///<summary>Soveværelse</summary>
		public ClimateEntity Sovevaerelse => new(_haContext, "climate.sovevaerelse");
		///<summary>Stue</summary>
		public ClimateEntity Stue => new(_haContext, "climate.stue");
		///<summary>Toilet</summary>
		public ClimateEntity Toilet => new(_haContext, "climate.toilet");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>ANNALINASIPHONE</summary>
		public DeviceTrackerEntity Annalinasiphone => new(_haContext, "device_tracker.annalinasiphone");
		///<summary>Candy Simply-Fi Oven</summary>
		public DeviceTrackerEntity CandySimplyFiOven => new(_haContext, "device_tracker.candy_simply_fi_oven");
		///<summary>CEED Location</summary>
		public DeviceTrackerEntity CeedLocation => new(_haContext, "device_tracker.ceed_location");
		///<summary>CHROMECAST</summary>
		public DeviceTrackerEntity Chromecast => new(_haContext, "device_tracker.chromecast");
		///<summary>CHROMECAST</summary>
		public DeviceTrackerEntity Chromecast2 => new(_haContext, "device_tracker.chromecast_2");
		///<summary>CHROMECAST</summary>
		public DeviceTrackerEntity Chromecast3 => new(_haContext, "device_tracker.chromecast_3");
		///<summary>DESKTOP-9T9VAUC</summary>
		public DeviceTrackerEntity Desktop9t9vauc => new(_haContext, "device_tracker.desktop_9t9vauc");
		///<summary>DK-KLE-850G5</summary>
		public DeviceTrackerEntity DkKle850g5 => new(_haContext, "device_tracker.dk_kle_850g5");
		///<summary>DK-KLE-FURYZ15</summary>
		public DeviceTrackerEntity DkKleFuryz15 => new(_haContext, "device_tracker.dk_kle_furyz15");
		///<summary>DK-KLE-FURYZ15</summary>
		public DeviceTrackerEntity DkKleFuryz152 => new(_haContext, "device_tracker.dk_kle_furyz15_2");
		///<summary>ERIK--IPAD</summary>
		public DeviceTrackerEntity ErikIpad => new(_haContext, "device_tracker.erik_ipad");
		///<summary>ERIK--IPAD</summary>
		public DeviceTrackerEntity ErikIpad2 => new(_haContext, "device_tracker.erik_ipad_2");
		///<summary>ERIKS-IPHONE</summary>
		public DeviceTrackerEntity EriksIphone => new(_haContext, "device_tracker.eriks_iphone");
		///<summary>ESP_10269B</summary>
		public DeviceTrackerEntity Esp10269b => new(_haContext, "device_tracker.esp_10269b");
		///<summary>ESP_207210</summary>
		public DeviceTrackerEntity Esp207210 => new(_haContext, "device_tracker.esp_207210");
		///<summary>ESP_DBBFC1</summary>
		public DeviceTrackerEntity EspDbbfc1 => new(_haContext, "device_tracker.esp_dbbfc1");
		///<summary>ESP_EB80F3</summary>
		public DeviceTrackerEntity EspEb80f3 => new(_haContext, "device_tracker.esp_eb80f3");
		///<summary>GALAXY-S20</summary>
		public DeviceTrackerEntity GalaxyS20 => new(_haContext, "device_tracker.galaxy_s20");
		///<summary>GALAXY-S8</summary>
		public DeviceTrackerEntity GalaxyS8 => new(_haContext, "device_tracker.galaxy_s8");
		///<summary>GALAXY-S9</summary>
		public DeviceTrackerEntity GalaxyS9 => new(_haContext, "device_tracker.galaxy_s9");
		///<summary>GALAXY-S9</summary>
		public DeviceTrackerEntity GalaxyS92 => new(_haContext, "device_tracker.galaxy_s9_2");
		///<summary>GALAXY-TAB-S3</summary>
		public DeviceTrackerEntity GalaxyTabS3 => new(_haContext, "device_tracker.galaxy_tab_s3");
		///<summary>GALAXY-TAB-S3</summary>
		public DeviceTrackerEntity GalaxyTabS32 => new(_haContext, "device_tracker.galaxy_tab_s3_2");
		///<summary>GAMERGRO</summary>
		public DeviceTrackerEntity Gamergro => new(_haContext, "device_tracker.gamergro");
		///<summary>GROS-S20</summary>
		public DeviceTrackerEntity GrosS20 => new(_haContext, "device_tracker.gros_s20");
		///<summary>HF-LPB100</summary>
		public DeviceTrackerEntity HfLpb100 => new(_haContext, "device_tracker.hf_lpb100");
		///<summary>HF-LPB100</summary>
		public DeviceTrackerEntity HfLpb1002 => new(_haContext, "device_tracker.hf_lpb100_2");
		///<summary>HOMEASSISTANT</summary>
		public DeviceTrackerEntity Homeassistant => new(_haContext, "device_tracker.homeassistant");
		///<summary>HOMEASSISTANT</summary>
		public DeviceTrackerEntity Homeassistant2 => new(_haContext, "device_tracker.homeassistant_2");
		///<summary>HOMEASSISTANT</summary>
		public DeviceTrackerEntity Homeassistant3 => new(_haContext, "device_tracker.homeassistant_3");
		///<summary>INGE-M-LS-IPAD</summary>
		public DeviceTrackerEntity IngeMLsIpad => new(_haContext, "device_tracker.inge_m_ls_ipad");
		///<summary>INGE-M-LS-IPAD</summary>
		public DeviceTrackerEntity IngeMLsIpad2 => new(_haContext, "device_tracker.inge_m_ls_ipad_2");
		///<summary>INGEMLSIPHONE</summary>
		public DeviceTrackerEntity Ingemlsiphone => new(_haContext, "device_tracker.ingemlsiphone");
		///<summary>INGEMLSIPHONE</summary>
		public DeviceTrackerEntity Ingemlsiphone2 => new(_haContext, "device_tracker.ingemlsiphone_2");
		///<summary>Kristoffers Galaxy S20 Ultra</summary>
		public DeviceTrackerEntity KristoffersGalaxyS20Ultra => new(_haContext, "device_tracker.kristoffers_galaxy_s20_ultra");
		///<summary>KRISTOFFERS-GALAXY-S9</summary>
		public DeviceTrackerEntity KristoffersGalaxyS9 => new(_haContext, "device_tracker.kristoffers_galaxy_s9");
		///<summary>KRISTOFFERS-GALAXY-S9</summary>
		public DeviceTrackerEntity KristoffersGalaxyS92 => new(_haContext, "device_tracker.kristoffers_galaxy_s9_2");
		///<summary>KRISTOFFERS-GALAXY-S9</summary>
		public DeviceTrackerEntity KristoffersGalaxyS93 => new(_haContext, "device_tracker.kristoffers_galaxy_s9_3");
		///<summary>KRISTOFFERS-S20-ULTRA</summary>
		public DeviceTrackerEntity KristoffersS20Ultra => new(_haContext, "device_tracker.kristoffers_s20_ultra");
		///<summary>KRISTOFFERS-S20-ULTRA</summary>
		public DeviceTrackerEntity KristoffersS20Ultra2 => new(_haContext, "device_tracker.kristoffers_s20_ultra_2");
		///<summary>(null)</summary>
		public DeviceTrackerEntity KristoffersS20Ultra3 => new(_haContext, "device_tracker.kristoffers_s20_ultra_3");
		///<summary>LOUISELSIPHONE</summary>
		public DeviceTrackerEntity Louiselsiphone => new(_haContext, "device_tracker.louiselsiphone");
		///<summary>LTSKB0411</summary>
		public DeviceTrackerEntity Ltskb0411 => new(_haContext, "device_tracker.ltskb0411");
		///<summary>LTSKB0429</summary>
		public DeviceTrackerEntity Ltskb0429 => new(_haContext, "device_tracker.ltskb0429");
		///<summary>LTSKB0429</summary>
		public DeviceTrackerEntity Ltskb04292 => new(_haContext, "device_tracker.ltskb0429_2");
		///<summary>NEST-HELLO-E85C</summary>
		public DeviceTrackerEntity NestHelloE85c => new(_haContext, "device_tracker.nest_hello_e85c");
		///<summary>NINTENDO WII U</summary>
		public DeviceTrackerEntity NintendoWiiU => new(_haContext, "device_tracker.nintendo_wii_u");
		///<summary>NINTENDO WII U</summary>
		public DeviceTrackerEntity NintendoWiiU2 => new(_haContext, "device_tracker.nintendo_wii_u_2");
		///<summary>(null)</summary>
		public DeviceTrackerEntity Null => new(_haContext, "device_tracker.null");
		///<summary>(null)</summary>
		public DeviceTrackerEntity Null2 => new(_haContext, "device_tracker.null_2");
		///<summary>PEROHS-IPHONE</summary>
		public DeviceTrackerEntity PerohsIphone => new(_haContext, "device_tracker.perohs_iphone");
		///<summary>PlexSovevaerelse</summary>
		public DeviceTrackerEntity Plexsovevaerelse => new(_haContext, "device_tracker.plexsovevaerelse");
		///<summary>PlexSovevaerelse</summary>
		public DeviceTrackerEntity Plexsovevaerelse2 => new(_haContext, "device_tracker.plexsovevaerelse_2");
		///<summary>PRINTER</summary>
		public DeviceTrackerEntity Printer => new(_haContext, "device_tracker.printer");
		///<summary>printer</summary>
		public DeviceTrackerEntity Printer2 => new(_haContext, "device_tracker.printer_2");
		///<summary>RE450</summary>
		public DeviceTrackerEntity Re450 => new(_haContext, "device_tracker.re450");
		///<summary>RE450</summary>
		public DeviceTrackerEntity Re4502 => new(_haContext, "device_tracker.re450_2");
		///<summary>ROBOTIC MOWER</summary>
		public DeviceTrackerEntity RoboticMower => new(_haContext, "device_tracker.robotic_mower");
		///<summary>Grasputin</summary>
		public DeviceTrackerEntity RoboticMower2 => new(_haContext, "device_tracker.robotic_mower_2");
		///<summary>S78f354bf382f3aa3C 81FC</summary>
		public DeviceTrackerEntity S78f354bf382f3aa3c81fc => new(_haContext, "device_tracker.s78f354bf382f3aa3c_81fc");
		public DeviceTrackerEntity S9fc1e43d898f31bacDb8a => new(_haContext, "device_tracker.s9fc1e43d898f31bac_db8a");
		///<summary>SAMSUNG</summary>
		public DeviceTrackerEntity Samsung => new(_haContext, "device_tracker.samsung");
		///<summary>Samsung 7 Series (65)</summary>
		public DeviceTrackerEntity Samsung2 => new(_haContext, "device_tracker.samsung_2");
		///<summary>Saphe D0C9</summary>
		public DeviceTrackerEntity SapheD0c9 => new(_haContext, "device_tracker.saphe_d0c9");
		///<summary>Sc8bfaff5ce07e22cC 18B6</summary>
		public DeviceTrackerEntity Sc8bfaff5ce07e22cc18b6 => new(_haContext, "device_tracker.sc8bfaff5ce07e22cc_18b6");
		///<summary>Sd01db6144334011bC 998A</summary>
		public DeviceTrackerEntity Sd01db6144334011bc998a => new(_haContext, "device_tracker.sd01db6144334011bc_998a");
		///<summary>SEEDBOX</summary>
		public DeviceTrackerEntity Seedbox => new(_haContext, "device_tracker.seedbox");
		///<summary>SEEDBOX</summary>
		public DeviceTrackerEntity Seedbox2 => new(_haContext, "device_tracker.seedbox_2");
		///<summary>Gros Galaxy S20+</summary>
		public DeviceTrackerEntity SmG985f => new(_haContext, "device_tracker.sm_g985f");
		///<summary>SONOSZP</summary>
		public DeviceTrackerEntity Sonoszp => new(_haContext, "device_tracker.sonoszp");
		///<summary>SONOSZP</summary>
		public DeviceTrackerEntity Sonoszp2 => new(_haContext, "device_tracker.sonoszp_2");
		///<summary>SOVE</summary>
		public DeviceTrackerEntity Sove => new(_haContext, "device_tracker.sove");
		///<summary>SOVE</summary>
		public DeviceTrackerEntity Sove2 => new(_haContext, "device_tracker.sove_2");
		///<summary>STUFFS-XPS15</summary>
		public DeviceTrackerEntity StuffsXps15 => new(_haContext, "device_tracker.stuffs_xps15");
		///<summary>STUFFS-XPS15</summary>
		public DeviceTrackerEntity StuffsXps152 => new(_haContext, "device_tracker.stuffs_xps15_2");
		///<summary>TADO</summary>
		public DeviceTrackerEntity Tado => new(_haContext, "device_tracker.tado");
		///<summary>TADO</summary>
		public DeviceTrackerEntity Tado2 => new(_haContext, "device_tracker.tado_2");
		///<summary>TuyaDeathStar</summary>
		public DeviceTrackerEntity Tuyadeathstar => new(_haContext, "device_tracker.tuyadeathstar");
		///<summary>TuyaGaragedorSensor</summary>
		public DeviceTrackerEntity Tuyagaragedorsensor => new(_haContext, "device_tracker.tuyagaragedorsensor");
		///<summary>TuyaIndkorselKontakt</summary>
		public DeviceTrackerEntity Tuyaindkorselkontakt => new(_haContext, "device_tracker.tuyaindkorselkontakt");
		///<summary>TuyaIndkorselKontakt</summary>
		public DeviceTrackerEntity Tuyaindkorselkontakt2 => new(_haContext, "device_tracker.tuyaindkorselkontakt_2");
		///<summary>TuyaLEDRoarsSeng</summary>
		public DeviceTrackerEntity Tuyaledroarsseng => new(_haContext, "device_tracker.tuyaledroarsseng");
		///<summary>TuyaLEDRoarsSeng</summary>
		public DeviceTrackerEntity Tuyaledroarsseng2 => new(_haContext, "device_tracker.tuyaledroarsseng_2");
		///<summary>TuyaLoftKontakt</summary>
		public DeviceTrackerEntity Tuyaloftkontakt => new(_haContext, "device_tracker.tuyaloftkontakt");
		///<summary>TuyaLoftKontakt</summary>
		public DeviceTrackerEntity Tuyaloftkontakt2 => new(_haContext, "device_tracker.tuyaloftkontakt_2");
		///<summary>TuyaLoftSovevaerelse</summary>
		public DeviceTrackerEntity Tuyaloftsovevaerelse => new(_haContext, "device_tracker.tuyaloftsovevaerelse");
		///<summary>TuyaLysekrone1</summary>
		public DeviceTrackerEntity Tuyalysekrone1 => new(_haContext, "device_tracker.tuyalysekrone1");
		///<summary>TuyaLysekrone2</summary>
		public DeviceTrackerEntity Tuyalysekrone2 => new(_haContext, "device_tracker.tuyalysekrone2");
		///<summary>TuyaLysekrone3</summary>
		public DeviceTrackerEntity Tuyalysekrone3 => new(_haContext, "device_tracker.tuyalysekrone3");
		///<summary>TuyaLysekrone4</summary>
		public DeviceTrackerEntity Tuyalysekrone4 => new(_haContext, "device_tracker.tuyalysekrone4");
		///<summary>TuyaLysekrone5</summary>
		public DeviceTrackerEntity Tuyalysekrone5 => new(_haContext, "device_tracker.tuyalysekrone5");
		///<summary>TuyaLysekrone6</summary>
		public DeviceTrackerEntity Tuyalysekrone6 => new(_haContext, "device_tracker.tuyalysekrone6");
		///<summary>TuyaLysEntreMidt</summary>
		public DeviceTrackerEntity Tuyalysentremidt => new(_haContext, "device_tracker.tuyalysentremidt");
		///<summary>TuyaLysEntreMidt</summary>
		public DeviceTrackerEntity Tuyalysentremidt2 => new(_haContext, "device_tracker.tuyalysentremidt_2");
		///<summary>TuyaLysEntreModHoveddor</summary>
		public DeviceTrackerEntity Tuyalysentremodhoveddor => new(_haContext, "device_tracker.tuyalysentremodhoveddor");
		///<summary>TuyaLysEntreModHoveddor</summary>
		public DeviceTrackerEntity Tuyalysentremodhoveddor2 => new(_haContext, "device_tracker.tuyalysentremodhoveddor_2");
		///<summary>TuyaLysEntreModStue</summary>
		public DeviceTrackerEntity Tuyalysentremodstue => new(_haContext, "device_tracker.tuyalysentremodstue");
		///<summary>TuyaLysEntreModStue</summary>
		public DeviceTrackerEntity Tuyalysentremodstue2 => new(_haContext, "device_tracker.tuyalysentremodstue_2");
		///<summary>TuyaLysGangMidt</summary>
		public DeviceTrackerEntity Tuyalysgangmidt => new(_haContext, "device_tracker.tuyalysgangmidt");
		///<summary>TuyaLysGangMidt</summary>
		public DeviceTrackerEntity Tuyalysgangmidt2 => new(_haContext, "device_tracker.tuyalysgangmidt_2");
		///<summary>TuyaLysGangModKokken</summary>
		public DeviceTrackerEntity Tuyalysgangmodkokken => new(_haContext, "device_tracker.tuyalysgangmodkokken");
		///<summary>TuyaLysGangModKokken</summary>
		public DeviceTrackerEntity Tuyalysgangmodkokken2 => new(_haContext, "device_tracker.tuyalysgangmodkokken_2");
		///<summary>TuyaLysGangModVaerelser</summary>
		public DeviceTrackerEntity Tuyalysgangmodvaerelser => new(_haContext, "device_tracker.tuyalysgangmodvaerelser");
		///<summary>TuyaLysGangModVaerelser</summary>
		public DeviceTrackerEntity Tuyalysgangmodvaerelser2 => new(_haContext, "device_tracker.tuyalysgangmodvaerelser_2");
		///<summary>TuyaLysKokkenVaskH</summary>
		public DeviceTrackerEntity Tuyalyskokkenvaskh => new(_haContext, "device_tracker.tuyalyskokkenvaskh");
		///<summary>TuyaLysKokkenVaskM</summary>
		public DeviceTrackerEntity Tuyalyskokkenvaskm => new(_haContext, "device_tracker.tuyalyskokkenvaskm");
		///<summary>TuyaLysKokkenVaskM</summary>
		public DeviceTrackerEntity Tuyalyskokkenvaskm2 => new(_haContext, "device_tracker.tuyalyskokkenvaskm_2");
		///<summary>TuyaLysKokkenVaskV</summary>
		public DeviceTrackerEntity Tuyalyskokkenvaskv => new(_haContext, "device_tracker.tuyalyskokkenvaskv");
		///<summary>TuyaLysKokkenVaskV</summary>
		public DeviceTrackerEntity Tuyalyskokkenvaskv2 => new(_haContext, "device_tracker.tuyalyskokkenvaskv_2");
		///<summary>TuyaLysOverPejsen</summary>
		public DeviceTrackerEntity Tuyalysoverpejsen => new(_haContext, "device_tracker.tuyalysoverpejsen");
		///<summary>TuyaNatlampeRoar</summary>
		public DeviceTrackerEntity Tuyanatlamperoar => new(_haContext, "device_tracker.tuyanatlamperoar");
		///<summary>TuyaNatlampeRoar</summary>
		public DeviceTrackerEntity Tuyanatlamperoar2 => new(_haContext, "device_tracker.tuyanatlamperoar_2");
		///<summary>TuyaSeedboxKontakt</summary>
		public DeviceTrackerEntity Tuyaseedboxkontakt => new(_haContext, "device_tracker.tuyaseedboxkontakt");
		///<summary>TuyaSeedboxKontakt</summary>
		public DeviceTrackerEntity Tuyaseedboxkontakt2 => new(_haContext, "device_tracker.tuyaseedboxkontakt_2");
		///<summary>Garagedør</summary>
		public DeviceTrackerEntity Tuyaterrassekoleskab => new(_haContext, "device_tracker.tuyaterrassekoleskab");
		///<summary>TuyaTerrasseKontakt</summary>
		public DeviceTrackerEntity Tuyaterrassekontakt => new(_haContext, "device_tracker.tuyaterrassekontakt");
		///<summary>TuyaTerrasseKontakt</summary>
		public DeviceTrackerEntity Tuyaterrassekontakt2 => new(_haContext, "device_tracker.tuyaterrassekontakt_2");
		///<summary>TWINKLY_EDA359</summary>
		public DeviceTrackerEntity TwinklyEda359 => new(_haContext, "device_tracker.twinkly_eda359");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice => new(_haContext, "device_tracker.unnamed_device");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice10 => new(_haContext, "device_tracker.unnamed_device_10");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice11 => new(_haContext, "device_tracker.unnamed_device_11");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice12 => new(_haContext, "device_tracker.unnamed_device_12");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice13 => new(_haContext, "device_tracker.unnamed_device_13");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice14 => new(_haContext, "device_tracker.unnamed_device_14");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice15 => new(_haContext, "device_tracker.unnamed_device_15");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice16 => new(_haContext, "device_tracker.unnamed_device_16");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice2 => new(_haContext, "device_tracker.unnamed_device_2");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice3 => new(_haContext, "device_tracker.unnamed_device_3");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice4 => new(_haContext, "device_tracker.unnamed_device_4");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice5 => new(_haContext, "device_tracker.unnamed_device_5");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice6 => new(_haContext, "device_tracker.unnamed_device_6");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice7 => new(_haContext, "device_tracker.unnamed_device_7");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice8 => new(_haContext, "device_tracker.unnamed_device_8");
		///<summary>unnamed device</summary>
		public DeviceTrackerEntity UnnamedDevice9 => new(_haContext, "device_tracker.unnamed_device_9");
		///<summary>WB268384</summary>
		public DeviceTrackerEntity Wb268384 => new(_haContext, "device_tracker.wb268384");
		///<summary>WIN-F8S9DTB7ECU</summary>
		public DeviceTrackerEntity WinF8s9dtb7ecu => new(_haContext, "device_tracker.win_f8s9dtb7ecu");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan0 => new(_haContext, "device_tracker.wlan0");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan010 => new(_haContext, "device_tracker.wlan0_10");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan011 => new(_haContext, "device_tracker.wlan0_11");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan02 => new(_haContext, "device_tracker.wlan0_2");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan03 => new(_haContext, "device_tracker.wlan0_3");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan04 => new(_haContext, "device_tracker.wlan0_4");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan05 => new(_haContext, "device_tracker.wlan0_5");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan06 => new(_haContext, "device_tracker.wlan0_6");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan07 => new(_haContext, "device_tracker.wlan0_7");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan08 => new(_haContext, "device_tracker.wlan0_8");
		///<summary>WLAN0</summary>
		public DeviceTrackerEntity Wlan09 => new(_haContext, "device_tracker.wlan0_9");
		///<summary>XBOXONE</summary>
		public DeviceTrackerEntity Xboxone => new(_haContext, "device_tracker.xboxone");
		///<summary>XiaomiRoborockS5Max</summary>
		public DeviceTrackerEntity Xiaomiroborocks5max => new(_haContext, "device_tracker.xiaomiroborocks5max");
	}

	public partial class GroupEntities
	{
		private readonly IHaContext _haContext;
		public GroupEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alle folk</summary>
		public GroupEntity Folk => new(_haContext, "group.folk");
		///<summary>Enheder til Kristoffers ur</summary>
		public GroupEntity Garmin => new(_haContext, "group.garmin");
		///<summary>Ebbes værelse</summary>
		public GroupEntity LysEbbe => new(_haContext, "group.lys_ebbe");
		///<summary>Indendørs lys</summary>
		public GroupEntity LysIndendors => new(_haContext, "group.lys_indendors");
		///<summary>Køkken</summary>
		public GroupEntity LysKokken => new(_haContext, "group.lys_kokken");
		///<summary>Loft</summary>
		public GroupEntity LysLoft => new(_haContext, "group.lys_loft");
		///<summary>Roars værelse</summary>
		public GroupEntity LysRoar => new(_haContext, "group.lys_roar");
		///<summary>Soveværelse</summary>
		public GroupEntity LysSovevaerelse => new(_haContext, "group.lys_sovevaerelse");
		///<summary>Stue</summary>
		public GroupEntity LysStue => new(_haContext, "group.lys_stue");
		///<summary>Walk-in closet</summary>
		public GroupEntity LysWalkInCloset => new(_haContext, "group.lys_walk_in_closet");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bagkant for bilopladning aktiveret</summary>
		public InputBooleanEntity BagkantForBilopladningAktiveret => new(_haContext, "input_boolean.bagkant_for_bilopladning_aktiveret");
		///<summary>Emballage</summary>
		public InputBooleanEntity Emballage => new(_haContext, "input_boolean.emballage");
		///<summary>Ferietilstand</summary>
		public InputBooleanEntity Ferietilstand => new(_haContext, "input_boolean.ferietilstand");
		///<summary>Garagedør-sensor</summary>
		public InputBooleanEntity GaragedorSensor => new(_haContext, "input_boolean.garagedor_sensor");
		///<summary>Hjemme</summary>
		public InputBooleanEntity Hjemme => new(_haContext, "input_boolean.hjemme");
		///<summary>Kummefryser på pause</summary>
		public InputBooleanEntity KummefryserPaPause => new(_haContext, "input_boolean.kummefryser_pa_pause");
		///<summary>netdaemon_lerbaek_net_daemon_apps_alarms_car_not_charging_alarm_car_not_charging_alarm_app</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsAlarmsCarNotChargingAlarmCarNotChargingAlarmApp => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_alarms_car_not_charging_alarm_car_not_charging_alarm_app");
		///<summary>netdaemon_lerbaek_net_daemon_apps_automations_chest_freezer_chest_freezer</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsAutomationsChestFreezerChestFreezer => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_automations_chest_freezer_chest_freezer");
		///<summary>netdaemon_lerbaek_net_daemon_apps_automations_night_brightness</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsAutomationsNightBrightness => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_automations_night_brightness");
		///<summary>netdaemon_lerbaek_net_daemon_apps_integrations_campen_auktioner_campen_auktioner</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsIntegrationsCampenAuktionerCampenAuktioner => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_integrations_campen_auktioner_campen_auktioner");
		///<summary>netdaemon_lerbaek_net_daemon_apps_integrations_nordlux_nordlux</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsIntegrationsNordluxNordlux => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_integrations_nordlux_nordlux");
		///<summary>netdaemon_lerbaek_net_daemon_apps_monitoring_humidity</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsMonitoringHumidity => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_monitoring_humidity");
		///<summary>netdaemon_lerbaek_net_daemon_apps_monitoring_lectio_lectio_calendar</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsMonitoringLectioLectioCalendar => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_monitoring_lectio_lectio_calendar");
		///<summary>netdaemon_lerbaek_net_daemon_apps_monitoring_price_monitor_price_monitor</summary>
		public InputBooleanEntity NetdaemonLerbaekNetDaemonAppsMonitoringPriceMonitorPriceMonitor => new(_haContext, "input_boolean.netdaemon_lerbaek_net_daemon_apps_monitoring_price_monitor_price_monitor");
		///<summary>Night mode</summary>
		public InputBooleanEntity NightMode => new(_haContext, "input_boolean.night_mode");
		///<summary>Pap og papir</summary>
		public InputBooleanEntity PapOgPapir => new(_haContext, "input_boolean.pap_og_papir");
		///<summary>Restaffald</summary>
		public InputBooleanEntity Restaffald => new(_haContext, "input_boolean.restaffald");
		///<summary>Storskrald</summary>
		public InputBooleanEntity Storskrald => new(_haContext, "input_boolean.storskrald");
	}

	public partial class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bagkant for bilopladning</summary>
		public InputDatetimeEntity BagkantForBilopladning => new(_haContext, "input_datetime.bagkant_for_bilopladning");
	}

	public partial class InputTextEntities
	{
		private readonly IHaContext _haContext;
		public InputTextEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Campen watchlist</summary>
		public InputTextEntity CampenWatchlist => new(_haContext, "input_text.campen_watchlist");
		///<summary>NetDaemon error</summary>
		public InputTextEntity NetdaemonError => new(_haContext, "input_text.netdaemon_error");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Aläng</summary>
		public LightEntity Alang => new(_haContext, "light.alang");
		///<summary>Alle indendørs lys</summary>
		public LightEntity AlleIndendorsLys => new(_haContext, "light.alle_indendors_lys");
		///<summary>Badeværelse Loft</summary>
		public LightEntity BadevaerelseLoft => new(_haContext, "light.badevaerelse_loft");
		///<summary>Ballon</summary>
		public LightEntity Ballon => new(_haContext, "light.ballon");
		///<summary>Bryggers</summary>
		public LightEntity Bryggers => new(_haContext, "light.bryggers");
		///<summary>Felena Tassel</summary>
		public LightEntity FelenaTassel => new(_haContext, "light.felena_tassel");
		///<summary>Flowerpot VP1</summary>
		public LightEntity FlowerpotVp1 => new(_haContext, "light.flowerpot_vp1");
		///<summary>Garage-lanterne</summary>
		public LightEntity GarageLanterne => new(_haContext, "light.garage_lanterne");
		///<summary>Havelamper</summary>
		public LightEntity Havelamper => new(_haContext, "light.havelamper");
		///<summary>Hjørneterrasse</summary>
		public LightEntity Hjorneterrasse => new(_haContext, "light.hjorneterrasse");
		///<summary>Kanin-astronaut</summary>
		public LightEntity KaninAstronaut => new(_haContext, "light.kanin_astronaut");
		///<summary>Køkkenvask</summary>
		public LightEntity Kokkenvask => new(_haContext, "light.kokkenvask");
		///<summary>Lys i baghaven</summary>
		public LightEntity LysIBaghaven => new(_haContext, "light.lys_i_baghaven");
		///<summary>Lys i bryggerset</summary>
		public LightEntity LysIBryggerset => new(_haContext, "light.lys_i_bryggerset");
		///<summary>Lys i entré (midt)</summary>
		public LightEntity LysIEntreMidt => new(_haContext, "light.lys_i_entre_midt");
		///<summary>Lys i entré (mod hoveddør)</summary>
		public LightEntity LysIEntreModHoveddor => new(_haContext, "light.lys_i_entre_mod_hoveddor");
		///<summary>Lys i entré (mod stue)</summary>
		public LightEntity LysIEntreModStue => new(_haContext, "light.lys_i_entre_mod_stue");
		///<summary>Lys i entréen</summary>
		public LightEntity LysIEntreen => new(_haContext, "light.lys_i_entreen");
		///<summary>Lys i fordelingsgang (midt)</summary>
		public LightEntity LysIFordelingsgangMidt => new(_haContext, "light.lys_i_fordelingsgang_midt");
		///<summary>Lys i fordelingsgang (mod køkken)</summary>
		public LightEntity LysIFordelingsgangModKokken => new(_haContext, "light.lys_i_fordelingsgang_mod_kokken");
		///<summary>Lys i fordelingsgang (mod værelser)</summary>
		public LightEntity LysIFordelingsgangModVaerelser => new(_haContext, "light.lys_i_fordelingsgang_mod_vaerelser");
		///<summary>Lys i fordelingsgangen</summary>
		public LightEntity LysIFordelingsgangen => new(_haContext, "light.lys_i_fordelingsgangen");
		///<summary>Lys i indkørslen</summary>
		public LightEntity LysIIndkorslen => new(_haContext, "light.lys_i_indkorslen");
		///<summary>Lys i køkkenet</summary>
		public LightEntity LysIKokkenet => new(_haContext, "light.lys_i_kokkenet");
		///<summary>Lys i stuen</summary>
		public LightEntity LysIStuen => new(_haContext, "light.lys_i_stuen");
		///<summary>Lys på badeværelset</summary>
		public LightEntity LysPaBadevaerelset => new(_haContext, "light.lys_pa_badevaerelset");
		///<summary>Lys på Ebbes værelse</summary>
		public LightEntity LysPaEbbesVaerelse => new(_haContext, "light.lys_pa_ebbes_vaerelse");
		///<summary>Lys på Roars værelse</summary>
		public LightEntity LysPaRoarsVaerelse => new(_haContext, "light.lys_pa_roars_vaerelse");
		///<summary>Lys på soveværelset</summary>
		public LightEntity LysPaSovevaerelset => new(_haContext, "light.lys_pa_sovevaerelset");
		///<summary>Lys på toilettet</summary>
		public LightEntity LysPaToilettet => new(_haContext, "light.lys_pa_toilettet");
		///<summary>Lys på loftet</summary>
		public LightEntity LysPaaLoftet => new(_haContext, "light.lys_paa_loftet");
		///<summary>Lys under Roars seng</summary>
		public LightEntity LysUnderRoarsSeng => new(_haContext, "light.lys_under_roars_seng");
		///<summary>Natlampe</summary>
		public LightEntity Natlampe => new(_haContext, "light.natlampe");
		///<summary>Olive Tree Branch</summary>
		public LightEntity OliveTreeBranch => new(_haContext, "light.olive_tree_branch");
		///<summary>Partial: Aläng 1</summary>
		public LightEntity PartialAlang1 => new(_haContext, "light.partial_alang_1");
		///<summary>Partial: Aläng 2</summary>
		public LightEntity PartialAlang2 => new(_haContext, "light.partial_alang_2");
		///<summary>Partial: Aläng 3</summary>
		public LightEntity PartialAlang3 => new(_haContext, "light.partial_alang_3");
		///<summary>Partial: Badeværelse GU5.3 Bad</summary>
		public LightEntity PartialBadevaerelseGu53Bad => new(_haContext, "light.partial_badevaerelse_gu5_3_bad");
		///<summary>Partial: Badeværelse GU5.3 Midt</summary>
		public LightEntity PartialBadevaerelseGu53Midt => new(_haContext, "light.partial_badevaerelse_gu5_3_midt");
		///<summary>Partial: Badeværelse GU5.3 Toilet</summary>
		public LightEntity PartialBadevaerelseGu53Toilet => new(_haContext, "light.partial_badevaerelse_gu5_3_toilet");
		///<summary>Partial: Felena Tassel RGBW 1</summary>
		public LightEntity PartialFelenaTasselRgbw1 => new(_haContext, "light.partial_felena_tassel_rgbw_1");
		///<summary>Partial: Felena Tassel RGBW 2</summary>
		public LightEntity PartialFelenaTasselRgbw2 => new(_haContext, "light.partial_felena_tassel_rgbw_2");
		///<summary>Partial: Felena Tassel RGBW 3</summary>
		public LightEntity PartialFelenaTasselRgbw3 => new(_haContext, "light.partial_felena_tassel_rgbw_3");
		///<summary>Partial: Køkkenvask 1</summary>
		public LightEntity PartialKokkenvask1 => new(_haContext, "light.partial_kokkenvask_1");
		///<summary>Partial: Køkkenvask 2</summary>
		public LightEntity PartialKokkenvask2 => new(_haContext, "light.partial_kokkenvask_2");
		///<summary>Partial: Køkkenvask 3</summary>
		public LightEntity PartialKokkenvask3 => new(_haContext, "light.partial_kokkenvask_3");
		///<summary>Partial: Toilet (dør)</summary>
		public LightEntity PartialToiletDor => new(_haContext, "light.partial_toilet_dor");
		///<summary>Partial: Toilet (vindue)</summary>
		public LightEntity PartialToiletVindue => new(_haContext, "light.partial_toilet_vindue");
		///<summary>Spejllys</summary>
		public LightEntity Spejllys => new(_haContext, "light.spejllys");
		///<summary>Toilet</summary>
		public LightEntity Toilet => new(_haContext, "light.toilet");
		///<summary>Twinkly_EDA359</summary>
		public LightEntity TwinklyEda359 => new(_haContext, "light.twinkly_eda359");
		///<summary>Underskabsbelysning</summary>
		public LightEntity Underskabsbelysning => new(_haContext, "light.underskabsbelysning");
		///<summary>Valder</summary>
		public LightEntity Valder => new(_haContext, "light.valder");
		///<summary>Vinke-astronaut</summary>
		public LightEntity VinkeAstronaut => new(_haContext, "light.vinke_astronaut");
		///<summary>Walk-in closet</summary>
		public LightEntity WalkInCloset => new(_haContext, "light.walk_in_closet");
	}

	public partial class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>CEED Door Lock</summary>
		public LockEntity CeedDoorLock => new(_haContext, "lock.ceed_door_lock");
		///<summary>Wallbox Portal Locked/Unlocked</summary>
		public LockEntity WallboxPortalLockedUnlocked => new(_haContext, "lock.wallbox_portal_locked_unlocked");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse</summary>
		public MediaPlayerEntity Badevaerelse => new(_haContext, "media_player.badevaerelse");
		///<summary>CC Soveværelse</summary>
		public MediaPlayerEntity CcSovevaerelse => new(_haContext, "media_player.cc_sovevaerelse");
		///<summary>ChromeCast (Stue)</summary>
		public MediaPlayerEntity CcStue => new(_haContext, "media_player.cc_stue");
		///<summary>Chromecast5045</summary>
		public MediaPlayerEntity Chromecast5045 => new(_haContext, "media_player.chromecast5045");
		///<summary>ChromeTV</summary>
		public MediaPlayerEntity Chrometv => new(_haContext, "media_player.chrometv");
		///<summary>Plex (linda.emkjaer@gmail.com - Plex for iOS - Anna Lindas iPhone)</summary>
		public MediaPlayerEntity PlexLindaEmkjaerGmailComPlexForIosAnnaLindasIphone => new(_haContext, "media_player.plex_linda_emkjaer_gmail_com_plex_for_ios_anna_lindas_iphone");
		///<summary>Plex (Plex for LG - LG 55UM7400PLB)</summary>
		public MediaPlayerEntity PlexLindaEmkjaerGmailComPlexForLgLg55um7400plb => new(_haContext, "media_player.plex_linda_emkjaer_gmail_com_plex_for_lg_lg_55um7400plb");
		///<summary>Plex (louise.p8 - Plex for Samsung - TV UE22H5600)</summary>
		public MediaPlayerEntity PlexLouiseP8PlexForSamsungTvUe22h5600 => new(_haContext, "media_player.plex_louise_p8_plex_for_samsung_tv_ue22h5600");
		///<summary>Plex (louise.p8 - Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexLouisePedersenGmailComPlexCastChromecast => new(_haContext, "media_player.plex_louise_pedersen_gmail_com_plex_cast_chromecast");
		///<summary>Plex (louise.p8 - Plex for iOS - Louise L.s iPhone)</summary>
		public MediaPlayerEntity PlexLouisePedersenGmailComPlexForIosLouiseLSIphone => new(_haContext, "media_player.plex_louise_pedersen_gmail_com_plex_for_ios_louise_l_s_iphone");
		///<summary>Plex (louise.pedersen@gmail.com - Plex for LG - NetCast)</summary>
		public MediaPlayerEntity PlexLouisePedersenGmailComPlexForLgNetcast => new(_haContext, "media_player.plex_louise_pedersen_gmail_com_plex_for_lg_netcast");
		///<summary>Plex (louise.pedersen@gmail.com - Plex Web - Chrome - OSX)</summary>
		public MediaPlayerEntity PlexLouisePedersenGmailComPlexWebChromeOsx => new(_haContext, "media_player.plex_louise_pedersen_gmail_com_plex_web_chrome_osx");
		///<summary>Plex (louise.p8 - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexLouisePedersenGmailComPlexWebChromeWindows => new(_haContext, "media_player.plex_louise_pedersen_gmail_com_plex_web_chrome_windows");
		///<summary>Plex (mail147 - Plex Web - Microsoft Edge - Windows)</summary>
		public MediaPlayerEntity PlexMail147PlexWebMicrosoftEdgeWindows => new(_haContext, "media_player.plex_mail147_plex_web_microsoft_edge_windows");
		///<summary>Plex (mail2eep@gmail.com - Plex for Samsung - TV 2017)</summary>
		public MediaPlayerEntity PlexMail2eepGmailComPlexForSamsungTv2017 => new(_haContext, "media_player.plex_mail2eep_gmail_com_plex_for_samsung_tv_2017");
		///<summary>Plex (mail147 - Plex for Samsung - TV 2017)</summary>
		public MediaPlayerEntity PlexMail2eepGmailComPlexForSamsungTv20172 => new(_haContext, "media_player.plex_mail2eep_gmail_com_plex_for_samsung_tv_2017_2");
		///<summary>Plex (mail2eep@gmail.com - Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexMail2eepGmailComPlexWebChromeWindows => new(_haContext, "media_player.plex_mail2eep_gmail_com_plex_web_chrome_windows");
		///<summary>Plex (Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexPlexCastChromecast => new(_haContext, "media_player.plex_plex_cast_chromecast");
		///<summary>Plex (Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexPlexCastChromecast2 => new(_haContext, "media_player.plex_plex_cast_chromecast_2");
		///<summary>Plex (Plex Cast - Chromecast)</summary>
		public MediaPlayerEntity PlexPlexCastChromecast3 => new(_haContext, "media_player.plex_plex_cast_chromecast_3");
		///<summary>Plex (Plex for Android - Galaxy S8)</summary>
		public MediaPlayerEntity PlexPlexForAndroidGalaxyS8 => new(_haContext, "media_player.plex_plex_for_android_galaxy_s8");
		///<summary>Plex (Plex for Android - Galaxy Tab S3)</summary>
		public MediaPlayerEntity PlexPlexForAndroidGalaxyTabS3 => new(_haContext, "media_player.plex_plex_for_android_galaxy_tab_s3");
		///<summary>Plex (Plex for Android (Mobile) - Galaxy S20+)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobileGalaxyS20 => new(_haContext, "media_player.plex_plex_for_android_mobile_galaxy_s20");
		///<summary>Plex (Plex for Android (Mobile) - Galaxy S20 Ultra 5G)</summary>
		public MediaPlayerEntity PlexPlexForAndroidMobileSmG988b => new(_haContext, "media_player.plex_plex_for_android_mobile_sm_g988b");
		///<summary>Plex (Plex for Android (TV) - Chromecast)</summary>
		public MediaPlayerEntity PlexPlexForAndroidTvChromecast => new(_haContext, "media_player.plex_plex_for_android_tv_chromecast");
		///<summary>Plex (Plex for Kodi - Snuggles)</summary>
		public MediaPlayerEntity PlexPlexForKodiSnuggles => new(_haContext, "media_player.plex_plex_for_kodi_snuggles");
		///<summary>Plex (Plex for Samsung - TV 2018)</summary>
		public MediaPlayerEntity PlexPlexForSamsungTv2018 => new(_haContext, "media_player.plex_plex_for_samsung_tv_2018");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome => new(_haContext, "media_player.plex_plex_web_chrome");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome2 => new(_haContext, "media_player.plex_plex_web_chrome_2");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChrome3 => new(_haContext, "media_player.plex_plex_web_chrome_3");
		///<summary>Plex (Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexPlexWebChromeAndroid => new(_haContext, "media_player.plex_plex_web_chrome_android");
		///<summary>Plex (Plex Web - Chrome - Android)</summary>
		public MediaPlayerEntity PlexPlexWebChromeAndroid2 => new(_haContext, "media_player.plex_plex_web_chrome_android_2");
		///<summary>Plex (Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebChromeWindows => new(_haContext, "media_player.plex_plex_web_chrome_windows");
		///<summary>Plex (Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebChromeWindows2 => new(_haContext, "media_player.plex_plex_web_chrome_windows_2");
		///<summary>Plex (Plex Web - Chrome - Windows)</summary>
		public MediaPlayerEntity PlexPlexWebChromeWindows3 => new(_haContext, "media_player.plex_plex_web_chrome_windows_3");
		///<summary>Plex (Plex Web - Chrome)</summary>
		public MediaPlayerEntity PlexPlexWebChromeWindows4 => new(_haContext, "media_player.plex_plex_web_chrome_windows_4");
		///<summary>Plex (stadsg - Plex for Apple TV - Dagligstue)</summary>
		public MediaPlayerEntity PlexStadsgaard86GmailComPlexForAppleTvDagligstue => new(_haContext, "media_player.plex_stadsgaard86_gmail_com_plex_for_apple_tv_dagligstue");
		///<summary>Samsung 7 Series (65)</summary>
		public MediaPlayerEntity Samsung7Series65 => new(_haContext, "media_player.samsung_7_series_65");
		///<summary>Sove</summary>
		public MediaPlayerEntity Sove => new(_haContext, "media_player.sove");
		///<summary>[TV] Samsung 7 Series (65)</summary>
		public MediaPlayerEntity TvSamsung7Series65 => new(_haContext, "media_player.tv_samsung_7_series_65");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse Bass</summary>
		public NumberEntity BadevaerelseBass => new(_haContext, "number.badevaerelse_bass");
		///<summary>Badeværelse Treble</summary>
		public NumberEntity BadevaerelseTreble => new(_haContext, "number.badevaerelse_treble");
		///<summary>Wallbox Portal Max. Charging Current</summary>
		public NumberEntity WallboxPortalMaxChargingCurrent => new(_haContext, "number.wallbox_portal_max_charging_current");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Erik Ejler Pedersen</summary>
		public PersonEntity Erik => new(_haContext, "person.erik");
		///<summary>Gro</summary>
		public PersonEntity Gro => new(_haContext, "person.gro");
		///<summary>Inge Lerbæk Pedersen</summary>
		public PersonEntity Inge => new(_haContext, "person.inge");
		///<summary>Kia Ceed</summary>
		public PersonEntity KiaCeed => new(_haContext, "person.kia_ceed");
		///<summary>Kristoffer</summary>
		public PersonEntity Kristoffer => new(_haContext, "person.kristoffer");
		///<summary>Linda Emkjær</summary>
		public PersonEntity LindaEmkjaer => new(_haContext, "person.linda_emkjaer");
		///<summary>Louise Lerbæk Pedersen</summary>
		public PersonEntity LouiseLerbaekPedersen => new(_haContext, "person.louise_lerbaek_pedersen");
	}

	public partial class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Script: Test script</summary>
		public ScriptEntity E1623792778521 => new(_haContext, "script.1623792778521");
		///<summary>Bilopladning</summary>
		public ScriptEntity Bilopladning => new(_haContext, "script.bilopladning");
		///<summary>Halloween</summary>
		public ScriptEntity Halloween => new(_haContext, "script.halloween");
		///<summary>Hjem: Godnat</summary>
		public ScriptEntity HjemGodnat => new(_haContext, "script.hjem_godnat");
		///<summary>Indkørsel: Sluk lyset</summary>
		public ScriptEntity IndkorselSlukLyset => new(_haContext, "script.indkorsel_sluk_lyset");
		///<summary>Indkørsel: Tænd lyset</summary>
		public ScriptEntity IndkorselTaendLyset => new(_haContext, "script.indkorsel_taend_lyset");
		///<summary>Støvsuger: Pit-stop</summary>
		public ScriptEntity KokkenStovsugerPitstop => new(_haContext, "script.kokken_stovsuger_pitstop");
		///<summary>Garage: Luk port</summary>
		public ScriptEntity LukGaragen => new(_haContext, "script.luk_garagen");
		///<summary>Roar: Dæmp loftlys hvis tændt</summary>
		public ScriptEntity RoarDaempLoftlysHvisTaendt => new(_haContext, "script.roar_daemp_loftlys_hvis_taendt");
		///<summary>Roar: Dæmp natlampe hvis tændt</summary>
		public ScriptEntity RoarDaempLysHvisTaendt => new(_haContext, "script.roar_daemp_lys_hvis_taendt");
		///<summary>Roar: Dæmp lys under sengen hvis tændt</summary>
		public ScriptEntity RoarDampLysUnderSengenHvisTaendt => new(_haContext, "script.roar_damp_lys_under_sengen_hvis_taendt");
		///<summary>Hjem: Sluk indendørs lys</summary>
		public ScriptEntity SceneSlukAlleIndendorsLys => new(_haContext, "script.scene_sluk_alle_indendors_lys");
		///<summary>Køkken: Sluk lys</summary>
		public ScriptEntity SceneSlukLysetIKokkenet => new(_haContext, "script.scene_sluk_lyset_i_kokkenet");
		///<summary>Stue: Sluk lys</summary>
		public ScriptEntity SceneSlukLysetIStuen => new(_haContext, "script.scene_sluk_lyset_i_stuen");
		///<summary>Køkken: Tænd lys</summary>
		public ScriptEntity SceneTaendLysetIKokkenet => new(_haContext, "script.scene_taend_lyset_i_kokkenet");
		///<summary>Stue: Tænd lys</summary>
		public ScriptEntity SceneTandLysetIStuen => new(_haContext, "script.scene_tand_lyset_i_stuen");
		///<summary>Soveværelse: Sluk lys</summary>
		public ScriptEntity SovevaerelseSlukLys => new(_haContext, "script.sovevaerelse_sluk_lys");
		///<summary>Soveværelse: Tænd lys</summary>
		public ScriptEntity SovevaerelseTaendLys => new(_haContext, "script.sovevaerelse_taend_lys");
		///<summary>Støvsuger: Ebbes mad</summary>
		public ScriptEntity StovsugerEbbesMad => new(_haContext, "script.stovsuger_ebbes_mad");
		///<summary>Støvsuger: Gå hjem</summary>
		public ScriptEntity StovsugerGaaHjem => new(_haContext, "script.stovsuger_gaa_hjem");
		///<summary>Støvsuger: Højeste sugestyrke</summary>
		public ScriptEntity StovsugerHojesteSugestyrke => new(_haContext, "script.stovsuger_hojeste_sugestyrke");
		///<summary>Støvsuger: Køkken x 3</summary>
		public ScriptEntity StovsugerKokken => new(_haContext, "script.stovsuger_kokken");
		///<summary>Støvsuger: Køkken x 1</summary>
		public ScriptEntity StovsugerKokkenX1 => new(_haContext, "script.stovsuger_kokken_x_1");
		///<summary>Støvsuger: Køkken x 2</summary>
		public ScriptEntity StovsugerKokkenX2 => new(_haContext, "script.stovsuger_kokken_x_2");
		///<summary>Støvsuger: Kør hjem</summary>
		public ScriptEntity StovsugerKorHjem => new(_haContext, "script.stovsuger_kor_hjem");
		///<summary>Støvsuger: Laveste sugestyrke</summary>
		public ScriptEntity StovsugerLavesteSugestyrke => new(_haContext, "script.stovsuger_laveste_sugestyrke");
		///<summary>Støvsuger: Skift sugestyrke</summary>
		public ScriptEntity StovsugerSkiftSugestyrke => new(_haContext, "script.stovsuger_skift_sugestyrke");
		///<summary>Støvsuger: Start/pause</summary>
		public ScriptEntity StovsugerStartPause => new(_haContext, "script.stovsuger_start_pause");
		///<summary>Støvsuger: Vent til færdig</summary>
		public ScriptEntity StovsugerVentTilFardig => new(_haContext, "script.stovsuger_vent_til_fardig");
		///<summary>Garage: Åbn port</summary>
		public ScriptEntity AabnGaragen => new(_haContext, "script.aabn_garagen");
	}

	public partial class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Ballon power on behavior</summary>
		public SelectEntity BallonPowerOnBehavior => new(_haContext, "select.ballon_power_on_behavior");
		///<summary>Bryggers power on behavior</summary>
		public SelectEntity BryggersPowerOnBehavior => new(_haContext, "select.bryggers_power_on_behavior");
		///<summary>Flowerpot VP1 power on behavior</summary>
		public SelectEntity FlowerpotVp1PowerOnBehavior => new(_haContext, "select.flowerpot_vp1_power_on_behavior");
		///<summary>Garage-lanterne power on behavior</summary>
		public SelectEntity GarageLanternePowerOnBehavior => new(_haContext, "select.garage_lanterne_power_on_behavior");
		///<summary>Hjørneterrasse Power on behavior</summary>
		public SelectEntity HjorneterrassePowerOnBehavior => new(_haContext, "select.hjorneterrasse_power_on_behavior");
		///<summary>Kanin-astronaut power on behavior</summary>
		public SelectEntity KaninAstronautPowerOnBehavior2 => new(_haContext, "select.kanin_astronaut_power_on_behavior_2");
		///<summary>Partial: Aläng 1 power on behavior</summary>
		public SelectEntity PartialAlang1PowerOnBehavior => new(_haContext, "select.partial_alang_1_power_on_behavior");
		///<summary>Partial: Aläng 2 power on behavior</summary>
		public SelectEntity PartialAlang2PowerOnBehavior => new(_haContext, "select.partial_alang_2_power_on_behavior");
		///<summary>Partial: Aläng 3 power on behavior</summary>
		public SelectEntity PartialAlang3PowerOnBehavior => new(_haContext, "select.partial_alang_3_power_on_behavior");
		///<summary>Partial: Felena Tassel RGBW 1 power on behavior</summary>
		public SelectEntity PartialFelenaTasselRgbw1PowerOnBehavior => new(_haContext, "select.partial_felena_tassel_rgbw_1_power_on_behavior");
		///<summary>Partial: Felena Tassel RGBW 2 power on behavior</summary>
		public SelectEntity PartialFelenaTasselRgbw2PowerOnBehavior => new(_haContext, "select.partial_felena_tassel_rgbw_2_power_on_behavior");
		///<summary>Partial: Felena Tassel RGBW 3 power on behavior</summary>
		public SelectEntity PartialFelenaTasselRgbw3PowerOnBehavior => new(_haContext, "select.partial_felena_tassel_rgbw_3_power_on_behavior");
		///<summary>Partial: Køkkenvask 1 power on behavior</summary>
		public SelectEntity PartialKokkenvask1PowerOnBehavior => new(_haContext, "select.partial_kokkenvask_1_power_on_behavior");
		///<summary>Partial: Køkkenvask 2 power on behavior</summary>
		public SelectEntity PartialKokkenvask2PowerOnBehavior => new(_haContext, "select.partial_kokkenvask_2_power_on_behavior");
		///<summary>Partial: Køkkenvask 3 power on behavior</summary>
		public SelectEntity PartialKokkenvask3PowerOnBehavior => new(_haContext, "select.partial_kokkenvask_3_power_on_behavior");
		///<summary>Valder power on behavior</summary>
		public SelectEntity ValderPowerOnBehavior => new(_haContext, "select.valder_power_on_behavior");
		///<summary>Vinke-astronaut power on behavior</summary>
		public SelectEntity VinkeAstronautPowerOnBehavior => new(_haContext, "select.vinke_astronaut_power_on_behavior");
		///<summary>Walk-in closet power on behavior</summary>
		public SelectEntity WalkInClosetPowerOnBehavior => new(_haContext, "select.walk_in_closet_power_on_behavior");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>awesome</summary>
		public SensorEntity Awesome => new(_haContext, "sensor.awesome");
		///<summary>Badeværelse tado mode</summary>
		public SensorEntity BadevaerelseTadoMode => new(_haContext, "sensor.badevaerelse_tado_mode");
		///<summary>BryggersTS004F action</summary>
		public SensorEntity Bryggersts004fAction => new(_haContext, "sensor.bryggersts004f_action");
		///<summary>campen_watchlist</summary>
		public SensorEntity CampenWatchlist => new(_haContext, "sensor.campen_watchlist");
		///<summary>CEED Geocoded Location</summary>
		public SensorEntity CeedGeocodedLocation => new(_haContext, "sensor.ceed_geocoded_location");
		///<summary>CEED Last Update</summary>
		public SensorEntity CeedLastUpdate => new(_haContext, "sensor.ceed_last_update");
		///<summary>Fam. Lerbæk Emkjær weather condition</summary>
		public SensorEntity FamLerbaekEmkjaerWeatherCondition => new(_haContext, "sensor.fam_lerbaek_emkjaer_weather_condition");
		///<summary>Garageport-knap, bil action</summary>
		public SensorEntity GarageportKnapBilAction => new(_haContext, "sensor.garageport_knap_bil_action");
		///<summary>Gros Galaxy S20+ Battery Health</summary>
		public SensorEntity GrosGalaxyS20BatteryHealth => new(_haContext, "sensor.gros_galaxy_s20_battery_health");
		///<summary>Gros Galaxy S20+ Battery State</summary>
		public SensorEntity GrosGalaxyS20BatteryState => new(_haContext, "sensor.gros_galaxy_s20_battery_state");
		///<summary>Gros Galaxy S20+ Charger Type</summary>
		public SensorEntity GrosGalaxyS20ChargerType => new(_haContext, "sensor.gros_galaxy_s20_charger_type");
		///<summary>Gros Galaxy S20+ Last Removed Notification</summary>
		public SensorEntity GrosGalaxyS20LastRemovedNotification => new(_haContext, "sensor.gros_galaxy_s20_last_removed_notification");
		///<summary>Køkken / Gang tado mode</summary>
		public SensorEntity KokkenGangTadoMode => new(_haContext, "sensor.kokken_gang_tado_mode");
		///<summary>Køkkenvask-kontakt action</summary>
		public SensorEntity KokkenvaskKontaktAction => new(_haContext, "sensor.kokkenvask_kontakt_action");
		///<summary>Køkkenvask-kontakt click</summary>
		public SensorEntity KokkenvaskKontaktClick => new(_haContext, "sensor.kokkenvask_kontakt_click");
		///<summary>Kristoffers Galaxy S20 Ultra Battery State</summary>
		public SensorEntity KristoffersGalaxyS20UltraBatteritilstand => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_batteritilstand");
		///<summary>Kristoffers Galaxy S20 Ultra Battery Health</summary>
		public SensorEntity KristoffersGalaxyS20UltraBatteryHealth => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_battery_health");
		///<summary>Kristoffers Galaxy S20 Ultra Do Not Disturb Sensor</summary>
		public SensorEntity KristoffersGalaxyS20UltraDoNotDisturbSensor => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_do_not_disturb_sensor");
		///<summary>Kristoffers Galaxy S20 Ultra Geocoded Location</summary>
		public SensorEntity KristoffersGalaxyS20UltraGeocodedLocation => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_geocoded_location");
		///<summary>Kristoffers Galaxy S20 Ultra Charger Type</summary>
		public SensorEntity KristoffersGalaxyS20UltraOpladerType => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_oplader_type");
		///<summary>Kristoffers Galaxy S20 Ultra WiFi Connection</summary>
		public SensorEntity KristoffersGalaxyS20UltraWifiConnection => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_wifi_connection");
		///<summary>Ebbes værelse tado mode</summary>
		public SensorEntity LillebrorsVaerelseTadoMode => new(_haContext, "sensor.lillebrors_vaerelse_tado_mode");
		///<summary>netdaemon_status</summary>
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>nextcloud_activeUsers_last1hour</summary>
		public SensorEntity NextcloudActiveusersLast1hour => new(_haContext, "sensor.nextcloud_activeusers_last1hour");
		///<summary>nextcloud_activeUsers_last24hours</summary>
		public SensorEntity NextcloudActiveusersLast24hours => new(_haContext, "sensor.nextcloud_activeusers_last24hours");
		///<summary>nextcloud_activeUsers_last5minutes</summary>
		public SensorEntity NextcloudActiveusersLast5minutes => new(_haContext, "sensor.nextcloud_activeusers_last5minutes");
		///<summary>nextcloud_database_type</summary>
		public SensorEntity NextcloudDatabaseType => new(_haContext, "sensor.nextcloud_database_type");
		///<summary>nextcloud_database_version</summary>
		public SensorEntity NextcloudDatabaseVersion => new(_haContext, "sensor.nextcloud_database_version");
		///<summary>nextcloud_server_php_max_execution_time</summary>
		public SensorEntity NextcloudServerPhpMaxExecutionTime => new(_haContext, "sensor.nextcloud_server_php_max_execution_time");
		///<summary>nextcloud_server_php_memory_limit</summary>
		public SensorEntity NextcloudServerPhpMemoryLimit => new(_haContext, "sensor.nextcloud_server_php_memory_limit");
		///<summary>nextcloud_server_php_upload_max_filesize</summary>
		public SensorEntity NextcloudServerPhpUploadMaxFilesize => new(_haContext, "sensor.nextcloud_server_php_upload_max_filesize");
		///<summary>nextcloud_server_php_version</summary>
		public SensorEntity NextcloudServerPhpVersion => new(_haContext, "sensor.nextcloud_server_php_version");
		///<summary>nextcloud_server_webserver</summary>
		public SensorEntity NextcloudServerWebserver => new(_haContext, "sensor.nextcloud_server_webserver");
		///<summary>nextcloud_shares_num_fed_shares_received</summary>
		public SensorEntity NextcloudSharesNumFedSharesReceived => new(_haContext, "sensor.nextcloud_shares_num_fed_shares_received");
		///<summary>nextcloud_shares_num_fed_shares_sent</summary>
		public SensorEntity NextcloudSharesNumFedSharesSent => new(_haContext, "sensor.nextcloud_shares_num_fed_shares_sent");
		///<summary>nextcloud_shares_num_shares</summary>
		public SensorEntity NextcloudSharesNumShares => new(_haContext, "sensor.nextcloud_shares_num_shares");
		///<summary>nextcloud_shares_num_shares_groups</summary>
		public SensorEntity NextcloudSharesNumSharesGroups => new(_haContext, "sensor.nextcloud_shares_num_shares_groups");
		///<summary>nextcloud_shares_num_shares_link</summary>
		public SensorEntity NextcloudSharesNumSharesLink => new(_haContext, "sensor.nextcloud_shares_num_shares_link");
		///<summary>nextcloud_shares_num_shares_link_no_password</summary>
		public SensorEntity NextcloudSharesNumSharesLinkNoPassword => new(_haContext, "sensor.nextcloud_shares_num_shares_link_no_password");
		///<summary>nextcloud_shares_num_shares_mail</summary>
		public SensorEntity NextcloudSharesNumSharesMail => new(_haContext, "sensor.nextcloud_shares_num_shares_mail");
		///<summary>nextcloud_shares_num_shares_room</summary>
		public SensorEntity NextcloudSharesNumSharesRoom => new(_haContext, "sensor.nextcloud_shares_num_shares_room");
		///<summary>nextcloud_shares_num_shares_user</summary>
		public SensorEntity NextcloudSharesNumSharesUser => new(_haContext, "sensor.nextcloud_shares_num_shares_user");
		///<summary>nextcloud_storage_num_files</summary>
		public SensorEntity NextcloudStorageNumFiles => new(_haContext, "sensor.nextcloud_storage_num_files");
		///<summary>nextcloud_storage_num_storages</summary>
		public SensorEntity NextcloudStorageNumStorages => new(_haContext, "sensor.nextcloud_storage_num_storages");
		///<summary>nextcloud_storage_num_storages_home</summary>
		public SensorEntity NextcloudStorageNumStoragesHome => new(_haContext, "sensor.nextcloud_storage_num_storages_home");
		///<summary>nextcloud_storage_num_storages_local</summary>
		public SensorEntity NextcloudStorageNumStoragesLocal => new(_haContext, "sensor.nextcloud_storage_num_storages_local");
		///<summary>nextcloud_storage_num_storages_other</summary>
		public SensorEntity NextcloudStorageNumStoragesOther => new(_haContext, "sensor.nextcloud_storage_num_storages_other");
		///<summary>nextcloud_storage_num_users</summary>
		public SensorEntity NextcloudStorageNumUsers => new(_haContext, "sensor.nextcloud_storage_num_users");
		///<summary>nextcloud_system_apps_num_installed</summary>
		public SensorEntity NextcloudSystemAppsNumInstalled => new(_haContext, "sensor.nextcloud_system_apps_num_installed");
		///<summary>nextcloud_system_apps_num_updates_available</summary>
		public SensorEntity NextcloudSystemAppsNumUpdatesAvailable => new(_haContext, "sensor.nextcloud_system_apps_num_updates_available");
		///<summary>nextcloud_system_cpuload</summary>
		public SensorEntity NextcloudSystemCpuload => new(_haContext, "sensor.nextcloud_system_cpuload");
		///<summary>nextcloud_system_freespace</summary>
		public SensorEntity NextcloudSystemFreespace => new(_haContext, "sensor.nextcloud_system_freespace");
		///<summary>nextcloud_system_mem_free</summary>
		public SensorEntity NextcloudSystemMemFree => new(_haContext, "sensor.nextcloud_system_mem_free");
		///<summary>nextcloud_system_mem_total</summary>
		public SensorEntity NextcloudSystemMemTotal => new(_haContext, "sensor.nextcloud_system_mem_total");
		///<summary>nextcloud_system_memcache.distributed</summary>
		public SensorEntity NextcloudSystemMemcacheDistributed => new(_haContext, "sensor.nextcloud_system_memcache_distributed");
		///<summary>nextcloud_system_memcache.local</summary>
		public SensorEntity NextcloudSystemMemcacheLocal => new(_haContext, "sensor.nextcloud_system_memcache_local");
		///<summary>nextcloud_system_memcache.locking</summary>
		public SensorEntity NextcloudSystemMemcacheLocking => new(_haContext, "sensor.nextcloud_system_memcache_locking");
		///<summary>nextcloud_system_swap_free</summary>
		public SensorEntity NextcloudSystemSwapFree => new(_haContext, "sensor.nextcloud_system_swap_free");
		///<summary>nextcloud_system_swap_total</summary>
		public SensorEntity NextcloudSystemSwapTotal => new(_haContext, "sensor.nextcloud_system_swap_total");
		///<summary>nextcloud_system_theme</summary>
		public SensorEntity NextcloudSystemTheme => new(_haContext, "sensor.nextcloud_system_theme");
		///<summary>nextcloud_system_version</summary>
		public SensorEntity NextcloudSystemVersion => new(_haContext, "sensor.nextcloud_system_version");
		///<summary>Nykredit 0,5% 2053 med afdrag</summary>
		public SensorEntity Nykredit052053MedAfdrag => new(_haContext, "sensor.nykredit_05_2053_med_afdrag");
		///<summary>Nykredit 1% 2053 med afdrag</summary>
		public SensorEntity Nykredit12053MedAfdrag => new(_haContext, "sensor.nykredit_1_2053_med_afdrag");
		///<summary>Nykredit 1,5% 2053 med afdrag</summary>
		public SensorEntity Nykredit152053MedAfdrag => new(_haContext, "sensor.nykredit_15_2053_med_afdrag");
		///<summary>Nykredit 2% 2050 med afdrag</summary>
		public SensorEntity Nykredit22050MedAfdrag => new(_haContext, "sensor.nykredit_2_2050_med_afdrag");
		///<summary>Nykredit 2,5% 2053 med afdrag</summary>
		public SensorEntity Nykredit252053MedAfdrag => new(_haContext, "sensor.nykredit_25_2053_med_afdrag");
		///<summary>Nykredit 3% 2053 med afdrag</summary>
		public SensorEntity Nykredit32053MedAfdrag => new(_haContext, "sensor.nykredit_3_2053_med_afdrag");
		///<summary>Nykredit 3,5% 2053 med afdrag</summary>
		public SensorEntity Nykredit352053MedAfdrag => new(_haContext, "sensor.nykredit_35_2053_med_afdrag");
		///<summary>Nykredit 4% 2053 med afdrag</summary>
		public SensorEntity Nykredit42053MedAfdrag => new(_haContext, "sensor.nykredit_4_2053_med_afdrag");
		///<summary>renovation_emballage</summary>
		public SensorEntity RenovationEmballage => new(_haContext, "sensor.renovation_emballage");
		///<summary>Emballage</summary>
		public SensorEntity RenovationEmballageFormatted => new(_haContext, "sensor.renovation_emballage_formatted");
		///<summary>renovation_pappapir</summary>
		public SensorEntity RenovationPappapir => new(_haContext, "sensor.renovation_pappapir");
		///<summary>Pap og papir</summary>
		public SensorEntity RenovationPappapirFormatted => new(_haContext, "sensor.renovation_pappapir_formatted");
		///<summary>renovation_restaffald</summary>
		public SensorEntity RenovationRestaffald => new(_haContext, "sensor.renovation_restaffald");
		///<summary>Restaffald</summary>
		public SensorEntity RenovationRestaffaldFormatted => new(_haContext, "sensor.renovation_restaffald_formatted");
		///<summary>renovation_storskrald</summary>
		public SensorEntity RenovationStorskrald => new(_haContext, "sensor.renovation_storskrald");
		///<summary>Storskrald (afhentning)</summary>
		public SensorEntity RenovationStorskraldFormatted => new(_haContext, "sensor.renovation_storskrald_formatted");
		///<summary>renovation_storskrald_tilmeld</summary>
		public SensorEntity RenovationStorskraldTilmeld => new(_haContext, "sensor.renovation_storskrald_tilmeld");
		///<summary>Storskrald (tilmelding)</summary>
		public SensorEntity RenovationStorskraldTilmeldFormatted => new(_haContext, "sensor.renovation_storskrald_tilmeld_formatted");
		///<summary>Roars værelse tado mode</summary>
		public SensorEntity RoarsVaerelseTadoMode => new(_haContext, "sensor.roars_vaerelse_tado_mode");
		///<summary>Roborock S5 Max Last clean end</summary>
		public SensorEntity RoborockS5MaxLastCleanEnd => new(_haContext, "sensor.roborock_s5_max_last_clean_end");
		///<summary>Roborock S5 Max Last clean start</summary>
		public SensorEntity RoborockS5MaxLastCleanStart => new(_haContext, "sensor.roborock_s5_max_last_clean_start");
		///<summary>Samsung CLP-325W Tray tray_1</summary>
		public SensorEntity SamsungClp325wTrayTray1 => new(_haContext, "sensor.samsung_clp_325w_tray_tray_1");
		///<summary>Soveværelse tado mode</summary>
		public SensorEntity SovevaerelseTadoMode => new(_haContext, "sensor.sovevaerelse_tado_mode");
		///<summary>StøvsugerTS004F action</summary>
		public SensorEntity Stovsugerts004fAction => new(_haContext, "sensor.stovsugerts004f_action");
		///<summary>Stue-kontakt action</summary>
		public SensorEntity StueKontaktAction => new(_haContext, "sensor.stue_kontakt_action");
		///<summary>Stue tado mode</summary>
		public SensorEntity StueTadoMode => new(_haContext, "sensor.stue_tado_mode");
		///<summary>Toilet tado mode</summary>
		public SensorEntity ToiletTadoMode => new(_haContext, "sensor.toilet_tado_mode");
		///<summary>Underskabsbelysning-kontakt action</summary>
		public SensorEntity UnderskabsbelysningKontaktAction => new(_haContext, "sensor.underskabsbelysning_kontakt_action");
		///<summary>Underskabsbelysning-kontakt click</summary>
		public SensorEntity UnderskabsbelysningKontaktClick => new(_haContext, "sensor.underskabsbelysning_kontakt_click");
		///<summary>Walk-in-closet-kontakt action</summary>
		public SensorEntity WalkInClosetKontaktAction => new(_haContext, "sensor.walk_in_closet_kontakt_action");
		///<summary>Wallbox Portal Charging Speed</summary>
		public SensorEntity WallboxPortalChargingSpeed => new(_haContext, "sensor.wallbox_portal_charging_speed");
		///<summary>Wallbox Portal Cost</summary>
		public SensorEntity WallboxPortalCost => new(_haContext, "sensor.wallbox_portal_cost");
		///<summary>Wallbox Portal Current Mode</summary>
		public SensorEntity WallboxPortalCurrentMode => new(_haContext, "sensor.wallbox_portal_current_mode");
		///<summary>Wallbox Portal Depot Price</summary>
		public SensorEntity WallboxPortalDepotPrice => new(_haContext, "sensor.wallbox_portal_depot_price");
		///<summary>Wallbox Portal Status Description</summary>
		public SensorEntity WallboxPortalStatusDescription => new(_haContext, "sensor.wallbox_portal_status_description");
		///<summary>XR500 (Gateway) External IP</summary>
		public SensorEntity Xr500GatewayExternalIp => new(_haContext, "sensor.xr500_gateway_external_ip");
		///<summary>XR500 (Gateway) wan status</summary>
		public SensorEntity Xr500GatewayWanStatus => new(_haContext, "sensor.xr500_gateway_wan_status");
		///<summary>Badeværelse heating</summary>
		public NumericSensorEntity BadevaerelseHeating => new(_haContext, "sensor.badevaerelse_heating");
		///<summary>Badeværelse humidity</summary>
		public NumericSensorEntity BadevaerelseHumidity => new(_haContext, "sensor.badevaerelse_humidity");
		///<summary>Badeværelse temperature</summary>
		public NumericSensorEntity BadevaerelseTemperature => new(_haContext, "sensor.badevaerelse_temperature");
		///<summary>Bevægelse i stuen battery</summary>
		public NumericSensorEntity BevaegelseIStuenBattery => new(_haContext, "sensor.bevaegelse_i_stuen_battery");
		///<summary>BryggersTS004F battery</summary>
		public NumericSensorEntity Bryggersts004fBattery => new(_haContext, "sensor.bryggersts004f_battery");
		///<summary>CEED Car Battery</summary>
		public NumericSensorEntity CeedCarBattery => new(_haContext, "sensor.ceed_car_battery");
		///<summary>CEED Estimated Current Charge Duration</summary>
		public NumericSensorEntity CeedEstimatedCurrentChargeDuration => new(_haContext, "sensor.ceed_estimated_current_charge_duration");
		///<summary>CEED Estimated Portable Charge Duration</summary>
		public NumericSensorEntity CeedEstimatedPortableChargeDuration => new(_haContext, "sensor.ceed_estimated_portable_charge_duration");
		///<summary>CEED Estimated Station Charge Duration</summary>
		public NumericSensorEntity CeedEstimatedStationChargeDuration => new(_haContext, "sensor.ceed_estimated_station_charge_duration");
		///<summary>CEED EV Battery</summary>
		public NumericSensorEntity CeedEvBattery => new(_haContext, "sensor.ceed_ev_battery");
		///<summary>CEED Odometer</summary>
		public NumericSensorEntity CeedOdometer => new(_haContext, "sensor.ceed_odometer");
		///<summary>CEED Range by EV</summary>
		public NumericSensorEntity CeedRangeByEv => new(_haContext, "sensor.ceed_range_by_ev");
		///<summary>CEED Range by Fuel</summary>
		public NumericSensorEntity CeedRangeByFuel => new(_haContext, "sensor.ceed_range_by_fuel");
		///<summary>CEED Range Total</summary>
		public NumericSensorEntity CeedRangeTotal => new(_haContext, "sensor.ceed_range_total");
		///<summary>CEED Set Temperature</summary>
		public NumericSensorEntity CeedSetTemperature => new(_haContext, "sensor.ceed_set_temperature");
		///<summary>Dør: Stue battery</summary>
		public NumericSensorEntity DorStueBattery => new(_haContext, "sensor.dor_stue_battery");
		///<summary>Dør: Stue device temperature</summary>
		public NumericSensorEntity DorStueDeviceTemperature => new(_haContext, "sensor.dor_stue_device_temperature");
		///<summary>Dør: Stue power outage count</summary>
		public NumericSensorEntity DorStuePowerOutageCount => new(_haContext, "sensor.dor_stue_power_outage_count");
		///<summary>EForsyning Amount remaining</summary>
		public NumericSensorEntity EforsyningAmountRemaining => new(_haContext, "sensor.eforsyning_amount_remaining");
		///<summary>EForsyning Energy end</summary>
		public NumericSensorEntity EforsyningEnergyEnd => new(_haContext, "sensor.eforsyning_energy_end");
		///<summary>EForsyning Energy exp-end</summary>
		public NumericSensorEntity EforsyningEnergyExpEnd => new(_haContext, "sensor.eforsyning_energy_exp_end");
		///<summary>EForsyning Energy exp-used</summary>
		public NumericSensorEntity EforsyningEnergyExpUsed => new(_haContext, "sensor.eforsyning_energy_exp_used");
		///<summary>EForsyning Energy start</summary>
		public NumericSensorEntity EforsyningEnergyStart => new(_haContext, "sensor.eforsyning_energy_start");
		///<summary>EForsyning Energy total-used</summary>
		public NumericSensorEntity EforsyningEnergyTotalUsed => new(_haContext, "sensor.eforsyning_energy_total_used");
		///<summary>EForsyning Energy use-prognosis</summary>
		public NumericSensorEntity EforsyningEnergyUsePrognosis => new(_haContext, "sensor.eforsyning_energy_use_prognosis");
		///<summary>EForsyning Energy used</summary>
		public NumericSensorEntity EforsyningEnergyUsed => new(_haContext, "sensor.eforsyning_energy_used");
		///<summary>EForsyning Water end</summary>
		public NumericSensorEntity EforsyningWaterEnd => new(_haContext, "sensor.eforsyning_water_end");
		///<summary>EForsyning Water exp-end</summary>
		public NumericSensorEntity EforsyningWaterExpEnd => new(_haContext, "sensor.eforsyning_water_exp_end");
		///<summary>EForsyning Water exp-used</summary>
		public NumericSensorEntity EforsyningWaterExpUsed => new(_haContext, "sensor.eforsyning_water_exp_used");
		///<summary>EForsyning Water start</summary>
		public NumericSensorEntity EforsyningWaterStart => new(_haContext, "sensor.eforsyning_water_start");
		///<summary>EForsyning Water Temperature cooling</summary>
		public NumericSensorEntity EforsyningWaterTemperatureCooling => new(_haContext, "sensor.eforsyning_water_temperature_cooling");
		///<summary>EForsyning Water Temperature exp-return</summary>
		public NumericSensorEntity EforsyningWaterTemperatureExpReturn => new(_haContext, "sensor.eforsyning_water_temperature_exp_return");
		///<summary>EForsyning Water Temperature forward</summary>
		public NumericSensorEntity EforsyningWaterTemperatureForward => new(_haContext, "sensor.eforsyning_water_temperature_forward");
		///<summary>EForsyning Water Temperature return</summary>
		public NumericSensorEntity EforsyningWaterTemperatureReturn => new(_haContext, "sensor.eforsyning_water_temperature_return");
		///<summary>EForsyning Water total-used</summary>
		public NumericSensorEntity EforsyningWaterTotalUsed => new(_haContext, "sensor.eforsyning_water_total_used");
		///<summary>EForsyning Water use-prognosis</summary>
		public NumericSensorEntity EforsyningWaterUsePrognosis => new(_haContext, "sensor.eforsyning_water_use_prognosis");
		///<summary>EForsyning Water used</summary>
		public NumericSensorEntity EforsyningWaterUsed => new(_haContext, "sensor.eforsyning_water_used");
		///<summary>sensor Cost</summary>
		public NumericSensorEntity EloverblikEnergyTotalCost => new(_haContext, "sensor.eloverblik_energy_total_cost");
		///<summary>Fam. Lerbæk Emkjær outdoor temperature</summary>
		public NumericSensorEntity FamLerbaekEmkjaerOutdoorTemperature => new(_haContext, "sensor.fam_lerbaek_emkjaer_outdoor_temperature");
		///<summary>Fam. Lerbæk Emkjær solar percentage</summary>
		public NumericSensorEntity FamLerbaekEmkjaerSolarPercentage => new(_haContext, "sensor.fam_lerbaek_emkjaer_solar_percentage");
		///<summary>Garagedør-sensor battery</summary>
		public NumericSensorEntity GaragedorSensorBattery => new(_haContext, "sensor.garagedor_sensor_battery");
		///<summary>Garageport-knap, bil battery</summary>
		public NumericSensorEntity GarageportKnapBilBattery => new(_haContext, "sensor.garageport_knap_bil_battery");
		///<summary>Gros Galaxy S20+ Battery Level</summary>
		public NumericSensorEntity GrosGalaxyS20BatteryLevel => new(_haContext, "sensor.gros_galaxy_s20_battery_level");
		///<summary>Gros Galaxy S20+ Battery Power</summary>
		public NumericSensorEntity GrosGalaxyS20BatteryPower => new(_haContext, "sensor.gros_galaxy_s20_battery_power");
		///<summary>Gros Galaxy S20+ Battery Temperature</summary>
		public NumericSensorEntity GrosGalaxyS20BatteryTemperature => new(_haContext, "sensor.gros_galaxy_s20_battery_temperature");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Woodstock Sofabord 120 x 47 x 60 cm </summary>
		public NumericSensorEntity Ilvapricemonitor10557295642100692 => new(_haContext, "sensor.ilvapricemonitor_1055729_5642100692");
		///<summary>Køkken / Gang heating</summary>
		public NumericSensorEntity KokkenGangHeating => new(_haContext, "sensor.kokken_gang_heating");
		///<summary>Køkken / Gang humidity</summary>
		public NumericSensorEntity KokkenGangHumidity => new(_haContext, "sensor.kokken_gang_humidity");
		///<summary>Køkken / Gang temperature</summary>
		public NumericSensorEntity KokkenGangTemperature => new(_haContext, "sensor.kokken_gang_temperature");
		///<summary>Køkkenvask-kontakt battery</summary>
		public NumericSensorEntity KokkenvaskKontaktBattery => new(_haContext, "sensor.kokkenvask_kontakt_battery");
		///<summary>Kristoffers Galaxy S20 Ultra Battery Level</summary>
		public NumericSensorEntity KristoffersGalaxyS20UltraBatteriniveau => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_batteriniveau");
		///<summary>Kristoffers Galaxy S20 Ultra Battery Power</summary>
		public NumericSensorEntity KristoffersGalaxyS20UltraBatteryPower => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_battery_power");
		///<summary>Kristoffers Galaxy S20 Ultra Battery Temperature</summary>
		public NumericSensorEntity KristoffersGalaxyS20UltraBatteryTemperature => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_battery_temperature");
		///<summary>Kristoffers Galaxy S20 Ultra Bluetooth Connection</summary>
		public NumericSensorEntity KristoffersGalaxyS20UltraBluetoothConnection => new(_haContext, "sensor.kristoffers_galaxy_s20_ultra_bluetooth_connection");
		///<summary>Kummefryser-forbrug</summary>
		public NumericSensorEntity KummefryserForbrug => new(_haContext, "sensor.kummefryser_forbrug");
		///<summary>Kummefryser-økonomi</summary>
		public NumericSensorEntity KummefryserOkonomi => new(_haContext, "sensor.kummefryser_okonomi");
		///<summary>Kummefryser Power</summary>
		public NumericSensorEntity KummefryserPower => new(_haContext, "sensor.kummefryser_power");
		///<summary>Kummefryser, strømstyrke</summary>
		public NumericSensorEntity KummefryserStromstyrke => new(_haContext, "sensor.kummefryser_stromstyrke");
		///<summary>Ebbes værelse heating</summary>
		public NumericSensorEntity LillebrorsVaerelseHeating => new(_haContext, "sensor.lillebrors_vaerelse_heating");
		///<summary>Ebbes værelse humidity</summary>
		public NumericSensorEntity LillebrorsVaerelseHumidity => new(_haContext, "sensor.lillebrors_vaerelse_humidity");
		///<summary>Ebbes værelse temperature</summary>
		public NumericSensorEntity LillebrorsVaerelseTemperature => new(_haContext, "sensor.lillebrors_vaerelse_temperature");
		///<summary>Lys i indkørslen Power</summary>
		public NumericSensorEntity LysIIndkorslenPower => new(_haContext, "sensor.lys_i_indkorslen_power");
		///<summary>Lys i indkørslen, strømstyrke</summary>
		public NumericSensorEntity LysIIndkorslenStromstyrke => new(_haContext, "sensor.lys_i_indkorslen_stromstyrke");
		///<summary>nordpool_kwh_dk1_dkk_3_10_025</summary>
		public NumericSensorEntity NordpoolKwhDk1Dkk310025 => new(_haContext, "sensor.nordpool_kwh_dk1_dkk_3_10_025");
		///<summary>Orico HDD docking station Battery</summary>
		public NumericSensorEntity OricoHddDockingStationBattery => new(_haContext, "sensor.orico_hdd_docking_station_battery");
		///<summary>Plex (Seedbox)</summary>
		public NumericSensorEntity PlexSeedbox => new(_haContext, "sensor.plex_seedbox");
		///<summary>Roars værelse heating</summary>
		public NumericSensorEntity RoarsVaerelseHeating => new(_haContext, "sensor.roars_vaerelse_heating");
		///<summary>Roars værelse humidity</summary>
		public NumericSensorEntity RoarsVaerelseHumidity => new(_haContext, "sensor.roars_vaerelse_humidity");
		///<summary>Roars værelse temperature</summary>
		public NumericSensorEntity RoarsVaerelseTemperature => new(_haContext, "sensor.roars_vaerelse_temperature");
		///<summary>Roborock S5 Max Current clean area</summary>
		public NumericSensorEntity RoborockS5MaxCurrentCleanArea => new(_haContext, "sensor.roborock_s5_max_current_clean_area");
		///<summary>Roborock S5 Max Current clean duration</summary>
		public NumericSensorEntity RoborockS5MaxCurrentCleanDuration => new(_haContext, "sensor.roborock_s5_max_current_clean_duration");
		///<summary>Roborock S5 Max Last clean area</summary>
		public NumericSensorEntity RoborockS5MaxLastCleanArea => new(_haContext, "sensor.roborock_s5_max_last_clean_area");
		///<summary>Roborock S5 Max Last clean duration</summary>
		public NumericSensorEntity RoborockS5MaxLastCleanDuration => new(_haContext, "sensor.roborock_s5_max_last_clean_duration");
		///<summary>S78f354bf382f3aa3C 81FC Estimated Distance</summary>
		public NumericSensorEntity S78f354bf382f3aa3c81fcEstimatedDistance => new(_haContext, "sensor.s78f354bf382f3aa3c_81fc_estimated_distance");
		///<summary>Estimated Distance</summary>
		public NumericSensorEntity S9fc1e43d898f31bacDb8aEstimatedDistance => new(_haContext, "sensor.s9fc1e43d898f31bac_db8a_estimated_distance");
		///<summary>Samsung CLP-325W Toner black</summary>
		public NumericSensorEntity SamsungClp325wTonerBlack => new(_haContext, "sensor.samsung_clp_325w_toner_black");
		///<summary>Samsung CLP-325W Toner cyan</summary>
		public NumericSensorEntity SamsungClp325wTonerCyan => new(_haContext, "sensor.samsung_clp_325w_toner_cyan");
		///<summary>Samsung CLP-325W Toner magenta</summary>
		public NumericSensorEntity SamsungClp325wTonerMagenta => new(_haContext, "sensor.samsung_clp_325w_toner_magenta");
		///<summary>Samsung CLP-325W Toner yellow</summary>
		public NumericSensorEntity SamsungClp325wTonerYellow => new(_haContext, "sensor.samsung_clp_325w_toner_yellow");
		///<summary>Saphe D0C9 Estimated Distance</summary>
		public NumericSensorEntity SapheD0c9EstimatedDistance => new(_haContext, "sensor.saphe_d0c9_estimated_distance");
		///<summary>Sc8bfaff5ce07e22cC 18B6 Estimated Distance</summary>
		public NumericSensorEntity Sc8bfaff5ce07e22cc18b6EstimatedDistance => new(_haContext, "sensor.sc8bfaff5ce07e22cc_18b6_estimated_distance");
		///<summary>Sd01db6144334011bC 998A Estimated Distance</summary>
		public NumericSensorEntity Sd01db6144334011bc998aEstimatedDistance => new(_haContext, "sensor.sd01db6144334011bc_998a_estimated_distance");
		///<summary>Soveværelse heating</summary>
		public NumericSensorEntity SovevaerelseHeating => new(_haContext, "sensor.sovevaerelse_heating");
		///<summary>Soveværelse humidity</summary>
		public NumericSensorEntity SovevaerelseHumidity => new(_haContext, "sensor.sovevaerelse_humidity");
		///<summary>Soveværelse temperature</summary>
		public NumericSensorEntity SovevaerelseTemperature => new(_haContext, "sensor.sovevaerelse_temperature");
		///<summary>StøvsugerTS004F battery</summary>
		public NumericSensorEntity Stovsugerts004fBattery => new(_haContext, "sensor.stovsugerts004f_battery");
		///<summary>Stue heating</summary>
		public NumericSensorEntity StueHeating => new(_haContext, "sensor.stue_heating");
		///<summary>Stue humidity</summary>
		public NumericSensorEntity StueHumidity => new(_haContext, "sensor.stue_humidity");
		///<summary>Stue-kontakt battery</summary>
		public NumericSensorEntity StueKontaktBattery => new(_haContext, "sensor.stue_kontakt_battery");
		///<summary>Stue temperature</summary>
		public NumericSensorEntity StueTemperature => new(_haContext, "sensor.stue_temperature");
		///<summary>Temperatur på badeværelset</summary>
		public NumericSensorEntity TemperatureBadevaerelse => new(_haContext, "sensor.temperature_badevaerelse");
		///<summary>TGTG S.Brød (Brød & Bagværk)</summary>
		public NumericSensorEntity TgtgSBrodBrodBagvaerk => new(_haContext, "sensor.tgtg_s_brod_brod_bagvaerk");
		///<summary>TGTG SushiMania - Skanderborg (Frokost)</summary>
		public NumericSensorEntity TgtgSushimaniaSkanderborgFrokost => new(_haContext, "sensor.tgtg_sushimania_skanderborg_frokost");
		///<summary>Toilet heating</summary>
		public NumericSensorEntity ToiletHeating => new(_haContext, "sensor.toilet_heating");
		///<summary>Toilet humidity</summary>
		public NumericSensorEntity ToiletHumidity => new(_haContext, "sensor.toilet_humidity");
		///<summary>Toilet temperature</summary>
		public NumericSensorEntity ToiletTemperature => new(_haContext, "sensor.toilet_temperature");
		///<summary>Underskabsbelysning-kontakt battery</summary>
		public NumericSensorEntity UnderskabsbelysningKontaktBattery => new(_haContext, "sensor.underskabsbelysning_kontakt_battery");
		///<summary>Vindue: Ebbe battery</summary>
		public NumericSensorEntity VindueEbbeBattery => new(_haContext, "sensor.vindue_ebbe_battery");
		///<summary>Vindue: Ebbe device temperature</summary>
		public NumericSensorEntity VindueEbbeDeviceTemperature => new(_haContext, "sensor.vindue_ebbe_device_temperature");
		///<summary>Vindue: Ebbe power outage count</summary>
		public NumericSensorEntity VindueEbbePowerOutageCount => new(_haContext, "sensor.vindue_ebbe_power_outage_count");
		///<summary>Vindue: Roar battery</summary>
		public NumericSensorEntity VindueRoarBattery => new(_haContext, "sensor.vindue_roar_battery");
		///<summary>Vindue: Roar device temperature</summary>
		public NumericSensorEntity VindueRoarDeviceTemperature => new(_haContext, "sensor.vindue_roar_device_temperature");
		///<summary>Vindue: Roar power outage count</summary>
		public NumericSensorEntity VindueRoarPowerOutageCount => new(_haContext, "sensor.vindue_roar_power_outage_count");
		///<summary>Walk-in-closet-kontakt battery</summary>
		public NumericSensorEntity WalkInClosetKontaktBattery => new(_haContext, "sensor.walk_in_closet_kontakt_battery");
		///<summary>Wallbox Portal Added Energy</summary>
		public NumericSensorEntity WallboxPortalAddedEnergy => new(_haContext, "sensor.wallbox_portal_added_energy");
		///<summary>Wallbox Portal Added Range</summary>
		public NumericSensorEntity WallboxPortalAddedRange => new(_haContext, "sensor.wallbox_portal_added_range");
		///<summary>Wallbox Portal Charging Power</summary>
		public NumericSensorEntity WallboxPortalChargingPower => new(_haContext, "sensor.wallbox_portal_charging_power");
		///<summary>Wallbox Portal Discharged Energy</summary>
		public NumericSensorEntity WallboxPortalDischargedEnergy => new(_haContext, "sensor.wallbox_portal_discharged_energy");
		///<summary>Wallbox Portal Max Available Power</summary>
		public NumericSensorEntity WallboxPortalMaxAvailablePower => new(_haContext, "sensor.wallbox_portal_max_available_power");
		///<summary>Wallbox Portal Max. Charging Current</summary>
		public NumericSensorEntity WallboxPortalMaxChargingCurrent => new(_haContext, "sensor.wallbox_portal_max_charging_current");
		///<summary>Wallbox Portal State of Charge</summary>
		public NumericSensorEntity WallboxPortalStateOfCharge => new(_haContext, "sensor.wallbox_portal_state_of_charge");
		///<summary>XR500 (Gateway) B received</summary>
		public NumericSensorEntity Xr500GatewayBReceived => new(_haContext, "sensor.xr500_gateway_b_received");
		///<summary>XR500 (Gateway) B sent</summary>
		public NumericSensorEntity Xr500GatewayBSent => new(_haContext, "sensor.xr500_gateway_b_sent");
		///<summary>XR500 (Gateway) KiB/s received</summary>
		public NumericSensorEntity Xr500GatewayKibSReceived => new(_haContext, "sensor.xr500_gateway_kib_s_received");
		///<summary>XR500 (Gateway) KiB/s sent</summary>
		public NumericSensorEntity Xr500GatewayKibSSent => new(_haContext, "sensor.xr500_gateway_kib_s_sent");
		///<summary>XR500 (Gateway) KiB/s sent</summary>
		public NumericSensorEntity Xr500GatewayKibSSent2 => new(_haContext, "sensor.xr500_gateway_kib_s_sent_2");
		///<summary>XR500 (Gateway) packets received</summary>
		public NumericSensorEntity Xr500GatewayPacketsReceived => new(_haContext, "sensor.xr500_gateway_packets_received");
		///<summary>XR500 (Gateway) packets/s received</summary>
		public NumericSensorEntity Xr500GatewayPacketsSReceived => new(_haContext, "sensor.xr500_gateway_packets_s_received");
		///<summary>XR500 (Gateway) packets/s sent</summary>
		public NumericSensorEntity Xr500GatewayPacketsSSent => new(_haContext, "sensor.xr500_gateway_packets_s_sent");
		///<summary>XR500 (Gateway) packets/s sent</summary>
		public NumericSensorEntity Xr500GatewayPacketsSSent2 => new(_haContext, "sensor.xr500_gateway_packets_s_sent_2");
		///<summary>XR500 (Gateway) packets sent</summary>
		public NumericSensorEntity Xr500GatewayPacketsSent => new(_haContext, "sensor.xr500_gateway_packets_sent");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse Loudness</summary>
		public SwitchEntity BadevaerelseLoudness => new(_haContext, "switch.badevaerelse_loudness");
		///<summary>C'eed: Force update</summary>
		public SwitchEntity CeedForceUpdate => new(_haContext, "switch.ceed_force_update");
		///<summary>C'eed: Charge</summary>
		public SwitchEntity CeedToggleCharging => new(_haContext, "switch.ceed_toggle_charging");
		///<summary>Garagedør</summary>
		public SwitchEntity GaragedorStateIcons => new(_haContext, "switch.garagedor_state_icons");
		///<summary>Grasputin</summary>
		public SwitchEntity Grasputin => new(_haContext, "switch.grasputin");
		///<summary>Havelamper Socket 1</summary>
		public SwitchEntity HavelamperSocket1 => new(_haContext, "switch.havelamper_socket_1");
		///<summary>Hjørneterrasse Socket 1</summary>
		public SwitchEntity HjorneterrasseSocket1 => new(_haContext, "switch.hjorneterrasse_socket_1");
		///<summary>Kummefryser</summary>
		public SwitchEntity Kummefryser => new(_haContext, "switch.kummefryser");
		///<summary>Lys i indkørslen</summary>
		public SwitchEntity LysIIndkorslenSocket1 => new(_haContext, "switch.lys_i_indkorslen_socket_1");
		///<summary>Lys på loftet Socket 1</summary>
		public SwitchEntity LysPaLoftetSocket1 => new(_haContext, "switch.lys_pa_loftet_socket_1");
		///<summary>netdaemon_campenauktioner</summary>
		public SwitchEntity NetdaemonCampenauktioner => new(_haContext, "switch.netdaemon_campenauktioner");
		///<summary>netdaemon_car_not_charging_alarm_app</summary>
		public SwitchEntity NetdaemonCarNotChargingAlarmApp => new(_haContext, "switch.netdaemon_car_not_charging_alarm_app");
		///<summary>netdaemon_carnotchargingalarmapp</summary>
		public SwitchEntity NetdaemonCarnotchargingalarmapp => new(_haContext, "switch.netdaemon_carnotchargingalarmapp");
		///<summary>netdaemon_garbage_collection_alarm_app</summary>
		public SwitchEntity NetdaemonGarbageCollectionAlarmApp => new(_haContext, "switch.netdaemon_garbage_collection_alarm_app");
		///<summary>netdaemon_garbagecollectionalarmapp</summary>
		public SwitchEntity NetdaemonGarbagecollectionalarmapp => new(_haContext, "switch.netdaemon_garbagecollectionalarmapp");
		///<summary>netdaemon_generatedappbase</summary>
		public SwitchEntity NetdaemonGeneratedappbase => new(_haContext, "switch.netdaemon_generatedappbase");
		///<summary>netdaemon_hello_world_app</summary>
		public SwitchEntity NetdaemonHelloWorldApp => new(_haContext, "switch.netdaemon_hello_world_app");
		///<summary>netdaemon_helloappcontext</summary>
		public SwitchEntity NetdaemonHelloappcontext => new(_haContext, "switch.netdaemon_helloappcontext");
		///<summary>netdaemon_helloworldapp</summary>
		public SwitchEntity NetdaemonHelloworldapp => new(_haContext, "switch.netdaemon_helloworldapp");
		///<summary>netdaemon_lightonmovement</summary>
		public SwitchEntity NetdaemonLightonmovement => new(_haContext, "switch.netdaemon_lightonmovement");
		///<summary>netdaemon_nordlux_integration</summary>
		public SwitchEntity NetdaemonNordluxIntegration => new(_haContext, "switch.netdaemon_nordlux_integration");
		///<summary>netdaemon_reset_lights_app</summary>
		public SwitchEntity NetdaemonResetLightsApp => new(_haContext, "switch.netdaemon_reset_lights_app");
		///<summary>netdaemon_schedulingapp</summary>
		public SwitchEntity NetdaemonSchedulingapp => new(_haContext, "switch.netdaemon_schedulingapp");
		///<summary>netdaemon_voice_alarm_app</summary>
		public SwitchEntity NetdaemonVoiceAlarmApp => new(_haContext, "switch.netdaemon_voice_alarm_app");
		///<summary>netdaemon_voicealarmapp</summary>
		public SwitchEntity NetdaemonVoicealarmapp => new(_haContext, "switch.netdaemon_voicealarmapp");
		///<summary>netdaemon_yaml_config_app</summary>
		public SwitchEntity NetdaemonYamlConfigApp => new(_haContext, "switch.netdaemon_yaml_config_app");
		///<summary>Orico HDD docking station</summary>
		public SwitchEntity OricoHddDockingStation => new(_haContext, "switch.orico_hdd_docking_station");
		///<summary>Seedbox</summary>
		public SwitchEntity Seedbox => new(_haContext, "switch.seedbox");
		///<summary>Garagedør</summary>
		public SwitchEntity SonoffGaragedor => new(_haContext, "switch.sonoff_garagedor");
		///<summary>Sonoff switch</summary>
		public SwitchEntity SonoffSwitch => new(_haContext, "switch.sonoff_switch");
		///<summary>Badeværelse Crossfade</summary>
		public SwitchEntity SonosBadevaerelseCrossfade => new(_haContext, "switch.sonos_badevaerelse_crossfade");
		///<summary>Wallbox Portal Pause/Resume</summary>
		public SwitchEntity WallboxPortalPauseResume => new(_haContext, "switch.wallbox_portal_pause_resume");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>AppDaemon Update</summary>
		public UpdateEntity AppdaemonUpdate => new(_haContext, "update.appdaemon_update");
		///<summary>eWeLink Smart Home Update</summary>
		public UpdateEntity EwelinkSmartHomeUpdate => new(_haContext, "update.ewelink_smart_home_update");
		///<summary>Git pull Update</summary>
		public UpdateEntity GitPullUpdate => new(_haContext, "update.git_pull_update");
		///<summary>Home Assistant Core Update</summary>
		public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
		///<summary>Home Assistant Operating System Update</summary>
		public UpdateEntity HomeAssistantOperatingSystemUpdate => new(_haContext, "update.home_assistant_operating_system_update");
		///<summary>Home Assistant Supervisor Update</summary>
		public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
		///<summary>Mosquitto broker Update</summary>
		public UpdateEntity MosquittoBrokerUpdate => new(_haContext, "update.mosquitto_broker_update");
		///<summary>NetDaemon V3 - beta Update</summary>
		public UpdateEntity NetdaemonV3BetaUpdate => new(_haContext, "update.netdaemon_v3_beta_update");
		///<summary>Samba share Update</summary>
		public UpdateEntity SambaShareUpdate => new(_haContext, "update.samba_share_update");
		///<summary>SSH & Web Terminal Update</summary>
		public UpdateEntity SshWebTerminalUpdate => new(_haContext, "update.ssh_web_terminal_update");
		///<summary>Studio Code Server Update</summary>
		public UpdateEntity StudioCodeServerUpdate => new(_haContext, "update.studio_code_server_update");
		///<summary>Terminal & SSH Update</summary>
		public UpdateEntity TerminalSshUpdate => new(_haContext, "update.terminal_ssh_update");
		///<summary>XR500 Update</summary>
		public UpdateEntity Xr500Update => new(_haContext, "update.xr500_update");
		///<summary>Zigbee2MQTT Update</summary>
		public UpdateEntity Zigbee2mqttUpdate => new(_haContext, "update.zigbee2mqtt_update");
	}

	public partial class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Grasputin</summary>
		public VacuumEntity Grasputin => new(_haContext, "vacuum.grasputin");
		///<summary>Roborock S5 Max</summary>
		public VacuumEntity RoborockS5Max => new(_haContext, "vacuum.roborock_s5_max");
	}

	public partial class VarEntities
	{
		private readonly IHaContext _haContext;
		public VarEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Watchlist matches for Campen auktioner</summary>
		public VarEntity CampenMatchesMarkdown => new(_haContext, "var.campen_matches_markdown");
		///<summary>Watchlist for Campen Auktioner</summary>
		public VarEntity CampenWatchlist => new(_haContext, "var.campen_watchlist");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Forecast Hjem</summary>
		public WeatherEntity Hjem => new(_haContext, "weather.hjem");
		///<summary>Forecast Kærvej 32</summary>
		public WeatherEntity Kaervej32 => new(_haContext, "weather.kaervej_32");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hjem</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("color_temp_startup")]
		public double? ColorTempStartup { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("level_config")]
		public object? LevelConfig { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("tamper")]
		public bool? Tamper { get; init; }

		[JsonPropertyName("termination")]
		public string? Termination { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("vehicle_data")]
		public object? VehicleData { get; init; }

		[JsonPropertyName("vehicle_name")]
		public string? VehicleName { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("brand")]
		public string? Brand { get; init; }

		[JsonPropertyName("calibration_points")]
		public IReadOnlyList<object>? CalibrationPoints { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("model")]
		public string? Model { get; init; }

		[JsonPropertyName("model_name")]
		public string? ModelName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("used_api")]
		public string? UsedApi { get; init; }
	}

	public partial record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_humidity")]
		public double? CurrentHumidity { get; init; }

		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("default_overlay_seconds")]
		public double? DefaultOverlaySeconds { get; init; }

		[JsonPropertyName("default_overlay_type")]
		public string? DefaultOverlayType { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_action")]
		public string? HvacAction { get; init; }

		[JsonPropertyName("hvac_modes")]
		public IReadOnlyList<string>? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("offset_celsius")]
		public double? OffsetCelsius { get; init; }

		[JsonPropertyName("offset_fahrenheit")]
		public double? OffsetFahrenheit { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public IReadOnlyList<string>? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ip")]
		public string? Ip { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		[JsonPropertyName("major")]
		public double? Major { get; init; }

		[JsonPropertyName("minor")]
		public double? Minor { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("uuid")]
		public string? Uuid { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public partial record GroupEntity : Entity<GroupEntity, EntityState<GroupAttributes>, GroupAttributes>
	{
		public GroupEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public GroupEntity(Entity entity) : base(entity)
		{
		}
	}

	public record GroupAttributes
	{
		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("order")]
		public double? Order { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }
	}

	public partial record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("pattern")]
		public object? Pattern { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("bytes_per_led")]
		public double? BytesPerLed { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("color_temp_startup")]
		public double? ColorTempStartup { get; init; }

		[JsonPropertyName("device_name")]
		public string? DeviceName { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("flash_size")]
		public double? FlashSize { get; init; }

		[JsonPropertyName("frame_rate")]
		public double? FrameRate { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("fw_family")]
		public string? FwFamily { get; init; }

		[JsonPropertyName("hardware_version")]
		public string? HardwareVersion { get; init; }

		[JsonPropertyName("hs_color")]
		public IReadOnlyList<double>? HsColor { get; init; }

		[JsonPropertyName("hw_id")]
		public string? HwId { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("led_profile")]
		public string? LedProfile { get; init; }

		[JsonPropertyName("led_type")]
		public double? LedType { get; init; }

		[JsonPropertyName("level_config")]
		public object? LevelConfig { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("max_movies")]
		public double? MaxMovies { get; init; }

		[JsonPropertyName("max_supported_led")]
		public double? MaxSupportedLed { get; init; }

		[JsonPropertyName("measured_frame_rate")]
		public double? MeasuredFrameRate { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("movie_capacity")]
		public double? MovieCapacity { get; init; }

		[JsonPropertyName("number_of_led")]
		public double? NumberOfLed { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("product_code")]
		public string? ProductCode { get; init; }

		[JsonPropertyName("product_name")]
		public string? ProductName { get; init; }

		[JsonPropertyName("rgb_color")]
		public IReadOnlyList<double>? RgbColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("uptime")]
		public string? Uptime { get; init; }

		[JsonPropertyName("uuid")]
		public string? Uuid { get; init; }

		[JsonPropertyName("wire_type")]
		public double? WireType { get; init; }

		[JsonPropertyName("xy_color")]
		public IReadOnlyList<double>? XyColor { get; init; }
	}

	public partial record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("app_id")]
		public string? AppId { get; init; }

		[JsonPropertyName("app_name")]
		public string? AppName { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("entity_picture_local")]
		public object? EntityPictureLocal { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("group_members")]
		public IReadOnlyList<string>? GroupMembers { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("media_album_name")]
		public string? MediaAlbumName { get; init; }

		[JsonPropertyName("media_artist")]
		public string? MediaArtist { get; init; }

		[JsonPropertyName("media_content_id")]
		public object? MediaContentId { get; init; }

		[JsonPropertyName("media_content_rating")]
		public string? MediaContentRating { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_duration")]
		public double? MediaDuration { get; init; }

		[JsonPropertyName("media_episode")]
		public double? MediaEpisode { get; init; }

		[JsonPropertyName("media_library_title")]
		public string? MediaLibraryTitle { get; init; }

		[JsonPropertyName("media_position")]
		public double? MediaPosition { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("media_season")]
		public double? MediaSeason { get; init; }

		[JsonPropertyName("media_series_title")]
		public string? MediaSeriesTitle { get; init; }

		[JsonPropertyName("media_summary")]
		public string? MediaSummary { get; init; }

		[JsonPropertyName("media_title")]
		public string? MediaTitle { get; init; }

		[JsonPropertyName("player_source")]
		public string? PlayerSource { get; init; }

		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[JsonPropertyName("source_list")]
		public IReadOnlyList<string>? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("username")]
		public string? Username { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color")]
		public object? Color { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("color_temp_startup")]
		public double? ColorTempStartup { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("level_config")]
		public object? LevelConfig { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }

		[JsonPropertyName("power_on_behavior")]
		public string? PowerOnBehavior { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		[JsonPropertyName("address")]
		public object? Address { get; init; }

		[JsonPropertyName("administrative_area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("capa")]
		public double? Capa { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("country")]
		public string? Country { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("iso_country_code")]
		public string? IsoCountryCode { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("location")]
		public IReadOnlyList<double>? Location { get; init; }

		[JsonPropertyName("markdown")]
		public string? Markdown { get; init; }

		[JsonPropertyName("name")]
		public string? Name { get; init; }

		[JsonPropertyName("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[JsonPropertyName("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[JsonPropertyName("opt")]
		public double? Opt { get; init; }

		[JsonPropertyName("paper_size1")]
		public double? PaperSize1 { get; init; }

		[JsonPropertyName("paper_size2")]
		public double? PaperSize2 { get; init; }

		[JsonPropertyName("paper_type")]
		public double? PaperType { get; init; }

		[JsonPropertyName("phone")]
		public string? Phone { get; init; }

		[JsonPropertyName("postal_code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("premises")]
		public string? Premises { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public double? Status { get; init; }

		[JsonPropertyName("sub_administrative_area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("sub_locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("sub_thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("url")]
		public string? Url { get; init; }

		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("action")]
		public string? Action { get; init; }

		[JsonPropertyName("average")]
		public double? Average { get; init; }

		[JsonPropertyName("battery")]
		public double? Battery { get; init; }

		[JsonPropertyName("battery_low")]
		public bool? BatteryLow { get; init; }

		[JsonPropertyName("click")]
		public object? Click { get; init; }

		[JsonPropertyName("cnt")]
		public double? Cnt { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public IReadOnlyList<object>? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public IReadOnlyList<string>? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("contact")]
		public bool? Contact { get; init; }

		[JsonPropertyName("country")]
		public string? Country { get; init; }

		[JsonPropertyName("cron pattern")]
		public string? Cronpattern { get; init; }

		[JsonPropertyName("currency")]
		public string? Currency { get; init; }

		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("current_price")]
		public double? CurrentPrice { get; init; }

		[JsonPropertyName("data")]
		public object? Data { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_temperature")]
		public double? DeviceTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("Item ID")]
		public string? ItemID { get; init; }

		[JsonPropertyName("Item URL")]
		public string? ItemURL { get; init; }

		[JsonPropertyName("last_period")]
		public string? LastPeriod { get; init; }

		[JsonPropertyName("last_reset")]
		public string? LastReset { get; init; }

		[JsonPropertyName("last_run_success")]
		public object? LastRunSuccess { get; init; }

		[JsonPropertyName("Lerbæk - Plex for Kodi")]
		public string? LerbkPlexforKodi { get; init; }

		[JsonPropertyName("linkquality")]
		public double? Linkquality { get; init; }

		[JsonPropertyName("low price")]
		public bool? Lowprice { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("meter_period")]
		public string? MeterPeriod { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("occupancy")]
		public bool? Occupancy { get; init; }

		[JsonPropertyName("off_peak_1")]
		public double? OffPeak1 { get; init; }

		[JsonPropertyName("off_peak_2")]
		public double? OffPeak2 { get; init; }

		[JsonPropertyName("opt")]
		public double? Opt { get; init; }

		[JsonPropertyName("Original value")]
		public string? Originalvalue { get; init; }

		[JsonPropertyName("paired_devices")]
		public IReadOnlyList<string>? PairedDevices { get; init; }

		[JsonPropertyName("peak")]
		public double? Peak { get; init; }

		[JsonPropertyName("Pickup start")]
		public string? Pickupstart { get; init; }

		[JsonPropertyName("Pickup stop")]
		public string? Pickupstop { get; init; }

		[JsonPropertyName("power_outage_count")]
		public double? PowerOutageCount { get; init; }

		[JsonPropertyName("raw_today")]
		public IReadOnlyList<object>? RawToday { get; init; }

		[JsonPropertyName("raw_tomorrow")]
		public IReadOnlyList<object>? RawTomorrow { get; init; }

		[JsonPropertyName("region")]
		public string? Region { get; init; }

		[JsonPropertyName("remaining")]
		public double? Remaining { get; init; }

		[JsonPropertyName("repositories")]
		public IReadOnlyList<object>? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("setting")]
		public double? Setting { get; init; }

		[JsonPropertyName("Soldout date")]
		public string? Soldoutdate { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public object? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("tamper")]
		public bool? Tamper { get; init; }

		[JsonPropertyName("TGTG Price")]
		public string? TGTGPrice { get; init; }

		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonPropertyName("today")]
		public IReadOnlyList<double>? Today { get; init; }

		[JsonPropertyName("tomorrow")]
		public IReadOnlyList<double>? Tomorrow { get; init; }

		[JsonPropertyName("tomorrow_valid")]
		public bool? TomorrowValid { get; init; }

		[JsonPropertyName("unit")]
		public string? Unit { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("update")]
		public object? Update { get; init; }

		[JsonPropertyName("update_available")]
		public bool? UpdateAvailable { get; init; }

		[JsonPropertyName("voltage")]
		public double? Voltage { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("assumed_state")]
		public bool? AssumedState { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("last_run_success")]
		public bool? LastRunSuccess { get; init; }

		[JsonPropertyName("runtime_info")]
		public object? RuntimeInfo { get; init; }

		[JsonPropertyName("switch_mode")]
		public bool? SwitchMode { get; init; }

		[JsonPropertyName("templates")]
		public object? Templates { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public IReadOnlyList<string>? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record VarEntity : Entity<VarEntity, EntityState<VarAttributes>, VarAttributes>
	{
		public VarEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VarEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VarAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public IReadOnlyList<object>? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("precipitation_unit")]
		public string? PrecipitationUnit { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("pressure_unit")]
		public string? PressureUnit { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temperature_unit")]
		public string? TemperatureUnit { get; init; }

		[JsonPropertyName("visibility_unit")]
		public string? VisibilityUnit { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }

		[JsonPropertyName("wind_speed_unit")]
		public string? WindSpeedUnit { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<string>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GoogleAssistantServices GoogleAssistant { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		KiaUvoServices KiaUvo { get; }

		KodiServices Kodi { get; }

		LandroidCloudServices LandroidCloud { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NetdaemonServices Netdaemon { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		PlexServices Plex { get; }

		ProfilerServices Profiler { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		RestServices Rest { get; }

		RestCommandServices RestCommand { get; }

		SceneServices Scene { get; }

		ScheduleServices Schedule { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SonoffServices Sonoff { get; }

		SonosServices Sonos { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TadoServices Tado { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UpdateServices Update { get; }

		UtilityMeterServices UtilityMeter { get; }

		VacuumServices Vacuum { get; }

		VarServices Var { get; }

		WaterHeaterServices WaterHeater { get; }

		XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GoogleAssistantServices GoogleAssistant => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public KiaUvoServices KiaUvo => new(_haContext);
		public KodiServices Kodi => new(_haContext);
		public LandroidCloudServices LandroidCloud => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NetdaemonServices Netdaemon => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public PlexServices Plex => new(_haContext);
		public ProfilerServices Profiler => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public RestServices Rest => new(_haContext);
		public RestCommandServices RestCommand => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScheduleServices Schedule => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SonoffServices Sonoff => new(_haContext);
		public SonosServices Sonos => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TadoServices Tado => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public UtilityMeterServices UtilityMeter => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public VarServices Var => new(_haContext);
		public WaterHeaterServices WaterHeater => new(_haContext);
		public XiaomiCloudMapExtractorServices XiaomiCloudMapExtractor => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GoogleAssistantServices
	{
		private readonly IHaContext _haContext;
		public GoogleAssistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a request_sync command to Google.</summary>
		public void RequestSync(GoogleAssistantRequestSyncParameters data)
		{
			_haContext.CallService("google_assistant", "request_sync", null, data);
		}

		///<summary>Send a request_sync command to Google.</summary>
		///<param name="agentUserId">Only needed for automations. Specific Home Assistant user id (not username, ID in configuration > users > under username) to sync with Google Assistant. Do not need when you call this service through Home Assistant front end or API. Used in automation script or other place where context.user_id is missing.</param>
		public void RequestSync(string? @agentUserId = null)
		{
			_haContext.CallService("google_assistant", "request_sync", null, new GoogleAssistantRequestSyncParameters{AgentUserId = @agentUserId});
		}
	}

	public record GoogleAssistantRequestSyncParameters
	{
		///<summary>Only needed for automations. Specific Home Assistant user id (not username, ID in configuration > users > under username) to sync with Google Assistant. Do not need when you call this service through Home Assistant front end or API. Used in automation script or other place where context.user_id is missing.</summary>
		[JsonPropertyName("agent_user_id")]
		public string? AgentUserId { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32,87336</param>
		///<param name="longitude">Longitude of your location. eg: 117,22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32,87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117,22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class KiaUvoServices
	{
		private readonly IHaContext _haContext;
		public KiaUvoServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Force your vehicle to update its data</summary>
		public void ForceUpdate()
		{
			_haContext.CallService("kia_uvo", "force_update", null);
		}

		///<summary>sets ac and dc charge capacity limits</summary>
		public void SetChargeLimits(KiaUvoSetChargeLimitsParameters data)
		{
			_haContext.CallService("kia_uvo", "set_charge_limits", null, data);
		}

		///<summary>sets ac and dc charge capacity limits</summary>
		///<param name="dcLimit">max charge capacity using DC charger eg: 50</param>
		///<param name="acLimit">max charge capacity using AC charger eg: 50</param>
		public void SetChargeLimits(long? @dcLimit = null, long? @acLimit = null)
		{
			_haContext.CallService("kia_uvo", "set_charge_limits", null, new KiaUvoSetChargeLimitsParameters{DcLimit = @dcLimit, AcLimit = @acLimit});
		}

		///<summary>Start charging</summary>
		public void StartCharge()
		{
			_haContext.CallService("kia_uvo", "start_charge", null);
		}

		///<summary>TEST - Please use cautiously - start car and climate. Not all items available for all cars.  Refer to Hyundai or Kia app for which are supported for your car.</summary>
		public void StartClimate(KiaUvoStartClimateParameters data)
		{
			_haContext.CallService("kia_uvo", "start_climate", null, data);
		}

		///<summary>TEST - Please use cautiously - start car and climate. Not all items available for all cars.  Refer to Hyundai or Kia app for which are supported for your car.</summary>
		///<param name="duration">On Duration eg: 5</param>
		///<param name="climate">Enable the HVAC System eg: True</param>
		///<param name="temperature">Set temperature of climate control. Unit is specific to region. For US Kia, anything lower than 62 will be translated to 'LOW' and anything higher than 82 will be translated to 'HIGH', in accordance with the vehicle and the UVO app. eg: 21,5</param>
		///<param name="defrost">Front Windshield Defrost eg: False</param>
		///<param name="heating">Heated features like the steering wheel and rear window eg: False</param>
		public void StartClimate(long? @duration = null, bool? @climate = null, double? @temperature = null, bool? @defrost = null, bool? @heating = null)
		{
			_haContext.CallService("kia_uvo", "start_climate", null, new KiaUvoStartClimateParameters{Duration = @duration, Climate = @climate, Temperature = @temperature, Defrost = @defrost, Heating = @heating});
		}

		///<summary>Stop charging</summary>
		public void StopCharge()
		{
			_haContext.CallService("kia_uvo", "stop_charge", null);
		}

		///<summary>TEST - Please use cautiously - stop car and climate</summary>
		public void StopClimate()
		{
			_haContext.CallService("kia_uvo", "stop_climate", null);
		}

		///<summary>Update vehicle data from cache</summary>
		public void Update()
		{
			_haContext.CallService("kia_uvo", "update", null);
		}
	}

	public record KiaUvoSetChargeLimitsParameters
	{
		///<summary>max charge capacity using DC charger eg: 50</summary>
		[JsonPropertyName("dc_limit")]
		public long? DcLimit { get; init; }

		///<summary>max charge capacity using AC charger eg: 50</summary>
		[JsonPropertyName("ac_limit")]
		public long? AcLimit { get; init; }
	}

	public record KiaUvoStartClimateParameters
	{
		///<summary>On Duration eg: 5</summary>
		[JsonPropertyName("Duration")]
		public long? Duration { get; init; }

		///<summary>Enable the HVAC System eg: True</summary>
		[JsonPropertyName("Climate")]
		public bool? Climate { get; init; }

		///<summary>Set temperature of climate control. Unit is specific to region. For US Kia, anything lower than 62 will be translated to 'LOW' and anything higher than 82 will be translated to 'HIGH', in accordance with the vehicle and the UVO app. eg: 21,5</summary>
		[JsonPropertyName("Temperature")]
		public double? Temperature { get; init; }

		///<summary>Front Windshield Defrost eg: False</summary>
		[JsonPropertyName("Defrost")]
		public bool? Defrost { get; init; }

		///<summary>Heated features like the steering wheel and rear window eg: False</summary>
		[JsonPropertyName("Heating")]
		public bool? Heating { get; init; }
	}

	public class KodiServices
	{
		private readonly IHaContext _haContext;
		public KodiServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		public void AddToPlaylist(ServiceTarget target, KodiAddToPlaylistParameters data)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public void AddToPlaylist(ServiceTarget target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		public void CallMethod(ServiceTarget target, KodiCallMethodParameters data)
		{
			_haContext.CallService("kodi", "call_method", target, data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public void CallMethod(ServiceTarget target, string @method)
		{
			_haContext.CallService("kodi", "call_method", target, new KodiCallMethodParameters{Method = @method});
		}
	}

	public record KodiAddToPlaylistParameters
	{
		///<summary>Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</summary>
		[JsonPropertyName("media_type")]
		public string? MediaType { get; init; }

		///<summary>Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</summary>
		[JsonPropertyName("media_id")]
		public string? MediaId { get; init; }

		///<summary>Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</summary>
		[JsonPropertyName("media_name")]
		public string? MediaName { get; init; }

		///<summary>Optional artist name for filtering media. eg: AC/DC</summary>
		[JsonPropertyName("artist_name")]
		public string? ArtistName { get; init; }
	}

	public record KodiCallMethodParameters
	{
		///<summary>Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</summary>
		[JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public class LandroidCloudServices
	{
		private readonly IHaContext _haContext;
		public LandroidCloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set device config parameters</summary>
		///<param name="target">The target for this service call</param>
		public void Config(ServiceTarget target, LandroidCloudConfigParameters data)
		{
			_haContext.CallService("landroid_cloud", "config", target, data);
		}

		///<summary>Set device config parameters</summary>
		///<param name="target">The target for this service call</param>
		///<param name="raindelay">Set rain delay. Time in minutes ranging from 0 to 300. 0 = Disabled eg: 30</param>
		///<param name="timeextension">Set time extension. Extension in % ranging from -100 to 100 eg: -23</param>
		///<param name="multizoneDistances">Set multizone distance array in meters. 0 = Disabled. Format: 15, 80, 120, 155 eg: 15, 80, 120, 155</param>
		///<param name="multizoneProbabilities">Set multizone probabilities array. Format: 50, 10, 20, 20 eg: 50, 10, 20, 20</param>
		public void Config(ServiceTarget target, long? @raindelay = null, long? @timeextension = null, string? @multizoneDistances = null, string? @multizoneProbabilities = null)
		{
			_haContext.CallService("landroid_cloud", "config", target, new LandroidCloudConfigParameters{Raindelay = @raindelay, Timeextension = @timeextension, MultizoneDistances = @multizoneDistances, MultizoneProbabilities = @multizoneProbabilities});
		}

		///<summary>Start edgecut (if supported)</summary>
		///<param name="target">The target for this service call</param>
		public void Edgecut(ServiceTarget target)
		{
			_haContext.CallService("landroid_cloud", "edgecut", target);
		}

		///<summary>Toggle device lock</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target)
		{
			_haContext.CallService("landroid_cloud", "lock", target);
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		///<param name="target">The target for this service call</param>
		public void Ots(ServiceTarget target, LandroidCloudOtsParameters data)
		{
			_haContext.CallService("landroid_cloud", "ots", target, data);
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		///<param name="target">The target for this service call</param>
		///<param name="boundary">Do boundary (Edge cut) eg: True</param>
		///<param name="runtime">Run time in minutes eg: 60</param>
		public void Ots(ServiceTarget target, bool @boundary, long @runtime)
		{
			_haContext.CallService("landroid_cloud", "ots", target, new LandroidCloudOtsParameters{Boundary = @boundary, Runtime = @runtime});
		}

		///<summary>Toggle PartyMode (if supported)</summary>
		///<param name="target">The target for this service call</param>
		public void Partymode(ServiceTarget target)
		{
			_haContext.CallService("landroid_cloud", "partymode", target);
		}

		///<summary>Send a refresh request to the API endpoint - ONLY USE FOR RARE CASES</summary>
		///<param name="target">The target for this service call</param>
		public void Refresh(ServiceTarget target)
		{
			_haContext.CallService("landroid_cloud", "refresh", target);
		}

		///<summary>Restart device</summary>
		///<param name="target">The target for this service call</param>
		public void Restart(ServiceTarget target)
		{
			_haContext.CallService("landroid_cloud", "restart", target);
		}

		///<summary>Set or change the schedule of the mower</summary>
		///<param name="target">The target for this service call</param>
		public void Schedule(ServiceTarget target, LandroidCloudScheduleParameters data)
		{
			_haContext.CallService("landroid_cloud", "schedule", target, data);
		}

		///<summary>Set or change the schedule of the mower</summary>
		///<param name="target">The target for this service call</param>
		///<param name="type">Change primary or secondary schedule? eg: primary</param>
		///<param name="mondayStart">Starting time for monday eg: 11:00</param>
		///<param name="mondayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="mondayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="tuesdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="tuesdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="tuesdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="wednesdayStart">Starting time for monday eg: 11:00</param>
		///<param name="wednesdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="wednesdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="thursdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="thursdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="thursdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="fridayStart">When should the device start the task? eg: 11:00</param>
		///<param name="fridayEnd">When should the task stop? eg: 16:00</param>
		///<param name="fridayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="saturdayStart">Starting time for monday eg: 11:00</param>
		///<param name="saturdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="saturdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="sundayStart">When should the device start the task? eg: 11:00</param>
		///<param name="sundayEnd">When should the task stop? eg: 16:00</param>
		///<param name="sundayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		public void Schedule(ServiceTarget target, object @type, DateTime? @mondayStart = null, DateTime? @mondayEnd = null, bool? @mondayBoundary = null, DateTime? @tuesdayStart = null, DateTime? @tuesdayEnd = null, bool? @tuesdayBoundary = null, DateTime? @wednesdayStart = null, DateTime? @wednesdayEnd = null, bool? @wednesdayBoundary = null, DateTime? @thursdayStart = null, DateTime? @thursdayEnd = null, bool? @thursdayBoundary = null, DateTime? @fridayStart = null, DateTime? @fridayEnd = null, bool? @fridayBoundary = null, DateTime? @saturdayStart = null, DateTime? @saturdayEnd = null, bool? @saturdayBoundary = null, DateTime? @sundayStart = null, DateTime? @sundayEnd = null, bool? @sundayBoundary = null)
		{
			_haContext.CallService("landroid_cloud", "schedule", target, new LandroidCloudScheduleParameters{Type = @type, MondayStart = @mondayStart, MondayEnd = @mondayEnd, MondayBoundary = @mondayBoundary, TuesdayStart = @tuesdayStart, TuesdayEnd = @tuesdayEnd, TuesdayBoundary = @tuesdayBoundary, WednesdayStart = @wednesdayStart, WednesdayEnd = @wednesdayEnd, WednesdayBoundary = @wednesdayBoundary, ThursdayStart = @thursdayStart, ThursdayEnd = @thursdayEnd, ThursdayBoundary = @thursdayBoundary, FridayStart = @fridayStart, FridayEnd = @fridayEnd, FridayBoundary = @fridayBoundary, SaturdayStart = @saturdayStart, SaturdayEnd = @saturdayEnd, SaturdayBoundary = @saturdayBoundary, SundayStart = @sundayStart, SundayEnd = @sundayEnd, SundayBoundary = @sundayBoundary});
		}

		///<summary>Send a raw JSON command to the device</summary>
		///<param name="target">The target for this service call</param>
		public void SendRaw(ServiceTarget target, LandroidCloudSendRawParameters data)
		{
			_haContext.CallService("landroid_cloud", "send_raw", target, data);
		}

		///<summary>Send a raw JSON command to the device</summary>
		///<param name="target">The target for this service call</param>
		///<param name="json">Data to send, formatted as valid JSON eg: {'cmd': 1}</param>
		public void SendRaw(ServiceTarget target, string @json)
		{
			_haContext.CallService("landroid_cloud", "send_raw", target, new LandroidCloudSendRawParameters{Json = @json});
		}

		///<summary>Set which zone to be mowed next</summary>
		///<param name="target">The target for this service call</param>
		public void Setzone(ServiceTarget target, LandroidCloudSetzoneParameters data)
		{
			_haContext.CallService("landroid_cloud", "setzone", target, data);
		}

		///<summary>Set which zone to be mowed next</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Sets the zone number, ranging from 0 to 3, to be mowed next eg: 1</param>
		public void Setzone(ServiceTarget target, object @zone)
		{
			_haContext.CallService("landroid_cloud", "setzone", target, new LandroidCloudSetzoneParameters{Zone = @zone});
		}

		///<summary>Set wheel torque</summary>
		///<param name="target">The target for this service call</param>
		public void Torque(ServiceTarget target, LandroidCloudTorqueParameters data)
		{
			_haContext.CallService("landroid_cloud", "torque", target, data);
		}

		///<summary>Set wheel torque</summary>
		///<param name="target">The target for this service call</param>
		///<param name="torque">Set wheel torque. Ranging from -50% to 50% eg: 22</param>
		public void Torque(ServiceTarget target, long @torque)
		{
			_haContext.CallService("landroid_cloud", "torque", target, new LandroidCloudTorqueParameters{Torque = @torque});
		}
	}

	public record LandroidCloudConfigParameters
	{
		///<summary>Set rain delay. Time in minutes ranging from 0 to 300. 0 = Disabled eg: 30</summary>
		[JsonPropertyName("raindelay")]
		public long? Raindelay { get; init; }

		///<summary>Set time extension. Extension in % ranging from -100 to 100 eg: -23</summary>
		[JsonPropertyName("timeextension")]
		public long? Timeextension { get; init; }

		///<summary>Set multizone distance array in meters. 0 = Disabled. Format: 15, 80, 120, 155 eg: 15, 80, 120, 155</summary>
		[JsonPropertyName("multizone_distances")]
		public string? MultizoneDistances { get; init; }

		///<summary>Set multizone probabilities array. Format: 50, 10, 20, 20 eg: 50, 10, 20, 20</summary>
		[JsonPropertyName("multizone_probabilities")]
		public string? MultizoneProbabilities { get; init; }
	}

	public record LandroidCloudOtsParameters
	{
		///<summary>Do boundary (Edge cut) eg: True</summary>
		[JsonPropertyName("boundary")]
		public bool? Boundary { get; init; }

		///<summary>Run time in minutes eg: 60</summary>
		[JsonPropertyName("runtime")]
		public long? Runtime { get; init; }
	}

	public record LandroidCloudScheduleParameters
	{
		///<summary>Change primary or secondary schedule? eg: primary</summary>
		[JsonPropertyName("type")]
		public object? Type { get; init; }

		///<summary>Starting time for monday eg: 11:00</summary>
		[JsonPropertyName("monday_start")]
		public DateTime? MondayStart { get; init; }

		///<summary>When should the schedule stop on mondays? eg: 16:00</summary>
		[JsonPropertyName("monday_end")]
		public DateTime? MondayEnd { get; init; }

		///<summary>Should we start this schedule by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("monday_boundary")]
		public bool? MondayBoundary { get; init; }

		///<summary>When should the device start the task? eg: 11:00</summary>
		[JsonPropertyName("tuesday_start")]
		public DateTime? TuesdayStart { get; init; }

		///<summary>When should the task stop? eg: 16:00</summary>
		[JsonPropertyName("tuesday_end")]
		public DateTime? TuesdayEnd { get; init; }

		///<summary>Should we start this task by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("tuesday_boundary")]
		public bool? TuesdayBoundary { get; init; }

		///<summary>Starting time for monday eg: 11:00</summary>
		[JsonPropertyName("wednesday_start")]
		public DateTime? WednesdayStart { get; init; }

		///<summary>When should the schedule stop on mondays? eg: 16:00</summary>
		[JsonPropertyName("wednesday_end")]
		public DateTime? WednesdayEnd { get; init; }

		///<summary>Should we start this schedule by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("wednesday_boundary")]
		public bool? WednesdayBoundary { get; init; }

		///<summary>When should the device start the task? eg: 11:00</summary>
		[JsonPropertyName("thursday_start")]
		public DateTime? ThursdayStart { get; init; }

		///<summary>When should the task stop? eg: 16:00</summary>
		[JsonPropertyName("thursday_end")]
		public DateTime? ThursdayEnd { get; init; }

		///<summary>Should we start this task by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("thursday_boundary")]
		public bool? ThursdayBoundary { get; init; }

		///<summary>When should the device start the task? eg: 11:00</summary>
		[JsonPropertyName("friday_start")]
		public DateTime? FridayStart { get; init; }

		///<summary>When should the task stop? eg: 16:00</summary>
		[JsonPropertyName("friday_end")]
		public DateTime? FridayEnd { get; init; }

		///<summary>Should we start this task by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("friday_boundary")]
		public bool? FridayBoundary { get; init; }

		///<summary>Starting time for monday eg: 11:00</summary>
		[JsonPropertyName("saturday_start")]
		public DateTime? SaturdayStart { get; init; }

		///<summary>When should the schedule stop on mondays? eg: 16:00</summary>
		[JsonPropertyName("saturday_end")]
		public DateTime? SaturdayEnd { get; init; }

		///<summary>Should we start this schedule by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("saturday_boundary")]
		public bool? SaturdayBoundary { get; init; }

		///<summary>When should the device start the task? eg: 11:00</summary>
		[JsonPropertyName("sunday_start")]
		public DateTime? SundayStart { get; init; }

		///<summary>When should the task stop? eg: 16:00</summary>
		[JsonPropertyName("sunday_end")]
		public DateTime? SundayEnd { get; init; }

		///<summary>Should we start this task by cutting the boundary (edge cut)? eg: False</summary>
		[JsonPropertyName("sunday_boundary")]
		public bool? SundayBoundary { get; init; }
	}

	public record LandroidCloudSendRawParameters
	{
		///<summary>Data to send, formatted as valid JSON eg: {'cmd': 1}</summary>
		[JsonPropertyName("json")]
		public string? Json { get; init; }
	}

	public record LandroidCloudSetzoneParameters
	{
		///<summary>Sets the zone number, ranging from 0 to 3, to be mowed next eg: 1</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }
	}

	public record LandroidCloudTorqueParameters
	{
		///<summary>Set wheel torque. Ranging from -50% to 50% eg: 22</summary>
		[JsonPropertyName("torque")]
		public long? Torque { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(object? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public void Join(ServiceTarget target, string @groupMembers)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </summary>
		[JsonPropertyName("group_members")]
		public string? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NetdaemonServices
	{
		private readonly IHaContext _haContext;
		public NetdaemonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create an entity</summary>
		public void EntityCreate(NetdaemonEntityCreateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_create", null, data);
		}

		///<summary>Create an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityCreate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		///<summary>Remove an entity</summary>
		public void EntityRemove(NetdaemonEntityRemoveParameters data)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, data);
		}

		///<summary>Remove an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		public void EntityRemove(object? @entityId = null)
		{
			_haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters{EntityId = @entityId});
		}

		///<summary>Update an entity</summary>
		public void EntityUpdate(NetdaemonEntityUpdateParameters data)
		{
			_haContext.CallService("netdaemon", "entity_update", null, data);
		}

		///<summary>Update an entity</summary>
		///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
		///<param name="state">The state of the entity eg: Lorem ipsum</param>
		///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
		///<param name="unit">The unit of measurement for the entity</param>
		///<param name="options">List of options for a select entity</param>
		///<param name="attributes">The attributes of the entity</param>
		public void EntityUpdate(object? @entityId = null, object? @state = null, object? @icon = null, object? @unit = null, object? @options = null, object? @attributes = null)
		{
			_haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters{EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Options = @options, Attributes = @attributes});
		}

		public void OlivetreebranchGetstatus()
		{
			_haContext.CallService("netdaemon", "olivetreebranch_getstatus", null);
		}

		public void OlivetreebranchSetbrightness()
		{
			_haContext.CallService("netdaemon", "olivetreebranch_setbrightness", null);
		}

		public void OlivetreebranchSetcolortemperature()
		{
			_haContext.CallService("netdaemon", "olivetreebranch_setcolortemperature", null);
		}

		public void OlivetreebranchTurnoff()
		{
			_haContext.CallService("netdaemon", "olivetreebranch_turnoff", null);
		}

		public void OlivetreebranchTurnon()
		{
			_haContext.CallService("netdaemon", "olivetreebranch_turnon", null);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		public void RegisterService(NetdaemonRegisterServiceParameters data)
		{
			_haContext.CallService("netdaemon", "register_service", null, data);
		}

		///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
		///<param name="service">The name of the service to register</param>
		///<param name="class">The class that implements the service call</param>
		///<param name="method">The method to call</param>
		public void RegisterService(object? @service = null, object? @class = null, object? @method = null)
		{
			_haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters{Service = @service, Class = @class, Method = @method});
		}

		public void ReloadApps()
		{
			_haContext.CallService("netdaemon", "reload_apps", null);
		}
	}

	public record NetdaemonEntityCreateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonEntityRemoveParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public record NetdaemonEntityUpdateParameters
	{
		///<summary>The entity ID of the entity eg: sensor.awesome</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The state of the entity eg: Lorem ipsum</summary>
		[JsonPropertyName("state")]
		public object? State { get; init; }

		///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The unit of measurement for the entity</summary>
		[JsonPropertyName("unit")]
		public object? Unit { get; init; }

		///<summary>List of options for a select entity</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The attributes of the entity</summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }
	}

	public record NetdaemonRegisterServiceParameters
	{
		///<summary>The name of the service to register</summary>
		[JsonPropertyName("service")]
		public object? Service { get; init; }

		///<summary>The class that implements the service call</summary>
		[JsonPropertyName("class")]
		public object? Class { get; init; }

		///<summary>The method to call</summary>
		[JsonPropertyName("method")]
		public object? Method { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the mobile_app_gros_galaxy_s20 integration.</summary>
		public void MobileAppGrosGalaxyS20(NotifyMobileAppGrosGalaxyS20Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_gros_galaxy_s20", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_gros_galaxy_s20 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppGrosGalaxyS20(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_gros_galaxy_s20", null, new NotifyMobileAppGrosGalaxyS20Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_kristoffers_galaxy_s20_ultra integration.</summary>
		public void MobileAppKristoffersGalaxyS20Ultra(NotifyMobileAppKristoffersGalaxyS20UltraParameters data)
		{
			_haContext.CallService("notify", "mobile_app_kristoffers_galaxy_s20_ultra", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_kristoffers_galaxy_s20_ultra integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppKristoffersGalaxyS20Ultra(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_kristoffers_galaxy_s20_ultra", null, new NotifyMobileAppKristoffersGalaxyS20UltraParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyMobileAppGrosGalaxyS20Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppKristoffersGalaxyS20UltraParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class PlexServices
	{
		private readonly IHaContext _haContext;
		public PlexServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Refresh a Plex library to scan for new and updated media.</summary>
		public void RefreshLibrary(PlexRefreshLibraryParameters data)
		{
			_haContext.CallService("plex", "refresh_library", null, data);
		}

		///<summary>Refresh a Plex library to scan for new and updated media.</summary>
		///<param name="serverName">Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</param>
		///<param name="libraryName">Name of the Plex library to refresh. eg: TV Shows</param>
		public void RefreshLibrary(string @libraryName, string? @serverName = null)
		{
			_haContext.CallService("plex", "refresh_library", null, new PlexRefreshLibraryParameters{ServerName = @serverName, LibraryName = @libraryName});
		}

		///<summary>Scan for available clients from the Plex server(s), local network, and plex.tv.</summary>
		public void ScanForClients()
		{
			_haContext.CallService("plex", "scan_for_clients", null);
		}
	}

	public record PlexRefreshLibraryParameters
	{
		///<summary>Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</summary>
		[JsonPropertyName("server_name")]
		public string? ServerName { get; init; }

		///<summary>Name of the Plex library to refresh. eg: TV Shows</summary>
		[JsonPropertyName("library_name")]
		public string? LibraryName { get; init; }
	}

	public class ProfilerServices
	{
		private readonly IHaContext _haContext;
		public ProfilerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump the repr of all matching objects to the log.</summary>
		public void DumpLogObjects(ProfilerDumpLogObjectsParameters data)
		{
			_haContext.CallService("profiler", "dump_log_objects", null, data);
		}

		///<summary>Dump the repr of all matching objects to the log.</summary>
		///<param name="type">The type of objects to dump to the log. eg: State</param>
		public void DumpLogObjects(string @type)
		{
			_haContext.CallService("profiler", "dump_log_objects", null, new ProfilerDumpLogObjectsParameters{Type = @type});
		}

		///<summary>Log what is scheduled in the event loop.</summary>
		public void LogEventLoopScheduled()
		{
			_haContext.CallService("profiler", "log_event_loop_scheduled", null);
		}

		///<summary>Log the current frames for all threads.</summary>
		public void LogThreadFrames()
		{
			_haContext.CallService("profiler", "log_thread_frames", null);
		}

		///<summary>Start the Memory Profiler</summary>
		public void Memory(ProfilerMemoryParameters data)
		{
			_haContext.CallService("profiler", "memory", null, data);
		}

		///<summary>Start the Memory Profiler</summary>
		///<param name="seconds">The number of seconds to run the memory profiler.</param>
		public void Memory(long? @seconds = null)
		{
			_haContext.CallService("profiler", "memory", null, new ProfilerMemoryParameters{Seconds = @seconds});
		}

		///<summary>Start the Profiler</summary>
		public void Start(ProfilerStartParameters data)
		{
			_haContext.CallService("profiler", "start", null, data);
		}

		///<summary>Start the Profiler</summary>
		///<param name="seconds">The number of seconds to run the profiler.</param>
		public void Start(long? @seconds = null)
		{
			_haContext.CallService("profiler", "start", null, new ProfilerStartParameters{Seconds = @seconds});
		}

		///<summary>Start logging growth of objects in memory</summary>
		public void StartLogObjects(ProfilerStartLogObjectsParameters data)
		{
			_haContext.CallService("profiler", "start_log_objects", null, data);
		}

		///<summary>Start logging growth of objects in memory</summary>
		///<param name="scanInterval">The number of seconds between logging objects.</param>
		public void StartLogObjects(long? @scanInterval = null)
		{
			_haContext.CallService("profiler", "start_log_objects", null, new ProfilerStartLogObjectsParameters{ScanInterval = @scanInterval});
		}

		///<summary>Stop logging growth of objects in memory.</summary>
		public void StopLogObjects()
		{
			_haContext.CallService("profiler", "stop_log_objects", null);
		}
	}

	public record ProfilerDumpLogObjectsParameters
	{
		///<summary>The type of objects to dump to the log. eg: State</summary>
		[JsonPropertyName("type")]
		public string? Type { get; init; }
	}

	public record ProfilerMemoryParameters
	{
		///<summary>The number of seconds to run the memory profiler.</summary>
		[JsonPropertyName("seconds")]
		public long? Seconds { get; init; }
	}

	public record ProfilerStartParameters
	{
		///<summary>The number of seconds to run the profiler.</summary>
		[JsonPropertyName("seconds")]
		public long? Seconds { get; init; }
	}

	public record ProfilerStartLogObjectsParameters
	{
		///<summary>The number of seconds between logging objects.</summary>
		[JsonPropertyName("scan_interval")]
		public long? ScanInterval { get; init; }
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, object? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, object @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class RestServices
	{
		private readonly IHaContext _haContext;
		public RestServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all rest entities and notify services</summary>
		public void Reload()
		{
			_haContext.CallService("rest", "reload", null);
		}
	}

	public class RestCommandServices
	{
		private readonly IHaContext _haContext;
		public RestCommandServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void LectioLogin()
		{
			_haContext.CallService("rest_command", "lectio_login", null);
		}
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScheduleServices
	{
		private readonly IHaContext _haContext;
		public ScheduleServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the schedule configuration</summary>
		public void Reload()
		{
			_haContext.CallService("schedule", "reload", null);
		}
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void HA1623792778521()
		{
			_haContext.CallService("script", "1623792778521", null);
		}

		public void Bilopladning()
		{
			_haContext.CallService("script", "bilopladning", null);
		}

		public void Halloween()
		{
			_haContext.CallService("script", "halloween", null);
		}

		public void HjemGodnat()
		{
			_haContext.CallService("script", "hjem_godnat", null);
		}

		public void IndkorselSlukLyset()
		{
			_haContext.CallService("script", "indkorsel_sluk_lyset", null);
		}

		public void IndkorselTaendLyset()
		{
			_haContext.CallService("script", "indkorsel_taend_lyset", null);
		}

		public void KokkenStovsugerPitstop()
		{
			_haContext.CallService("script", "kokken_stovsuger_pitstop", null);
		}

		public void LukGaragen()
		{
			_haContext.CallService("script", "luk_garagen", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		public void RoarDaempLoftlysHvisTaendt()
		{
			_haContext.CallService("script", "roar_daemp_loftlys_hvis_taendt", null);
		}

		public void RoarDaempLysHvisTaendt()
		{
			_haContext.CallService("script", "roar_daemp_lys_hvis_taendt", null);
		}

		public void RoarDampLysUnderSengenHvisTaendt()
		{
			_haContext.CallService("script", "roar_damp_lys_under_sengen_hvis_taendt", null);
		}

		public void SceneSlukAlleIndendorsLys()
		{
			_haContext.CallService("script", "scene_sluk_alle_indendors_lys", null);
		}

		public void SceneSlukLysetIKokkenet()
		{
			_haContext.CallService("script", "scene_sluk_lyset_i_kokkenet", null);
		}

		public void SceneSlukLysetIStuen()
		{
			_haContext.CallService("script", "scene_sluk_lyset_i_stuen", null);
		}

		public void SceneTaendLysetIKokkenet()
		{
			_haContext.CallService("script", "scene_taend_lyset_i_kokkenet", null);
		}

		public void SceneTandLysetIStuen()
		{
			_haContext.CallService("script", "scene_tand_lyset_i_stuen", null);
		}

		public void SovevaerelseSlukLys()
		{
			_haContext.CallService("script", "sovevaerelse_sluk_lys", null);
		}

		public void SovevaerelseTaendLys()
		{
			_haContext.CallService("script", "sovevaerelse_taend_lys", null);
		}

		public void StovsugerEbbesMad()
		{
			_haContext.CallService("script", "stovsuger_ebbes_mad", null);
		}

		public void StovsugerGaaHjem()
		{
			_haContext.CallService("script", "stovsuger_gaa_hjem", null);
		}

		public void StovsugerHojesteSugestyrke()
		{
			_haContext.CallService("script", "stovsuger_hojeste_sugestyrke", null);
		}

		public void StovsugerKokken()
		{
			_haContext.CallService("script", "stovsuger_kokken", null);
		}

		public void StovsugerKokkenX1()
		{
			_haContext.CallService("script", "stovsuger_kokken_x_1", null);
		}

		public void StovsugerKokkenX2()
		{
			_haContext.CallService("script", "stovsuger_kokken_x_2", null);
		}

		public void StovsugerKorHjem()
		{
			_haContext.CallService("script", "stovsuger_kor_hjem", null);
		}

		public void StovsugerLavesteSugestyrke()
		{
			_haContext.CallService("script", "stovsuger_laveste_sugestyrke", null);
		}

		public void StovsugerSkiftSugestyrke()
		{
			_haContext.CallService("script", "stovsuger_skift_sugestyrke", null);
		}

		public void StovsugerStartPause()
		{
			_haContext.CallService("script", "stovsuger_start_pause", null);
		}

		public void StovsugerVentTilFardig()
		{
			_haContext.CallService("script", "stovsuger_vent_til_fardig", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}

		public void AabnGaragen()
		{
			_haContext.CallService("script", "aabn_garagen", null);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SonoffServices
	{
		private readonly IHaContext _haContext;
		public SonoffServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a command to a device.</summary>
		public void SendCommand(SonoffSendCommandParameters data)
		{
			_haContext.CallService("sonoff", "send_command", null, data);
		}

		///<summary>Sends a command to a device.</summary>
		///<param name="device">Device ID to send command to. eg: 1000123456</param>
		///<param name="cmd">A single command to send. eg: switch</param>
		public void SendCommand(object? @device = null, object? @cmd = null)
		{
			_haContext.CallService("sonoff", "send_command", null, new SonoffSendCommandParameters{Device = @device, Cmd = @cmd});
		}
	}

	public record SonoffSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 1000123456</summary>
		[JsonPropertyName("device")]
		public object? Device { get; init; }

		///<summary>A single command to send. eg: switch</summary>
		[JsonPropertyName("cmd")]
		public object? Cmd { get; init; }
	}

	public class SonosServices
	{
		private readonly IHaContext _haContext;
		public SonosServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSleepTimer(ServiceTarget target)
		{
			_haContext.CallService("sonos", "clear_sleep_timer", target);
		}

		///<summary>Start playing the queue from the first item.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayQueue(ServiceTarget target, SonosPlayQueueParameters data)
		{
			_haContext.CallService("sonos", "play_queue", target, data);
		}

		///<summary>Start playing the queue from the first item.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="queuePosition">Position of the song in the queue to start playing from.</param>
		public void PlayQueue(ServiceTarget target, long? @queuePosition = null)
		{
			_haContext.CallService("sonos", "play_queue", target, new SonosPlayQueueParameters{QueuePosition = @queuePosition});
		}

		///<summary>Removes an item from the queue.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoveFromQueue(ServiceTarget target, SonosRemoveFromQueueParameters data)
		{
			_haContext.CallService("sonos", "remove_from_queue", target, data);
		}

		///<summary>Removes an item from the queue.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="queuePosition">Position in the queue to remove.</param>
		public void RemoveFromQueue(ServiceTarget target, long? @queuePosition = null)
		{
			_haContext.CallService("sonos", "remove_from_queue", target, new SonosRemoveFromQueueParameters{QueuePosition = @queuePosition});
		}

		///<summary>Restore a snapshot of the media player.</summary>
		public void Restore(SonosRestoreParameters data)
		{
			_haContext.CallService("sonos", "restore", null, data);
		}

		///<summary>Restore a snapshot of the media player.</summary>
		///<param name="entityId">Name of entity that will be restored.</param>
		///<param name="withGroup">True or False. Also restore the group layout.</param>
		public void Restore(string? @entityId = null, bool? @withGroup = null)
		{
			_haContext.CallService("sonos", "restore", null, new SonosRestoreParameters{EntityId = @entityId, WithGroup = @withGroup});
		}

		///<summary>Set a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSleepTimer(ServiceTarget target, SonosSetSleepTimerParameters data)
		{
			_haContext.CallService("sonos", "set_sleep_timer", target, data);
		}

		///<summary>Set a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="sleepTime">Number of seconds to set the timer.</param>
		public void SetSleepTimer(ServiceTarget target, long? @sleepTime = null)
		{
			_haContext.CallService("sonos", "set_sleep_timer", target, new SonosSetSleepTimerParameters{SleepTime = @sleepTime});
		}

		///<summary>Take a snapshot of the media player.</summary>
		public void Snapshot(SonosSnapshotParameters data)
		{
			_haContext.CallService("sonos", "snapshot", null, data);
		}

		///<summary>Take a snapshot of the media player.</summary>
		///<param name="entityId">Name of entity that will be snapshot.</param>
		///<param name="withGroup">True or False. Also snapshot the group layout.</param>
		public void Snapshot(string? @entityId = null, bool? @withGroup = null)
		{
			_haContext.CallService("sonos", "snapshot", null, new SonosSnapshotParameters{EntityId = @entityId, WithGroup = @withGroup});
		}

		///<summary>Updates an alarm with new time and volume settings.</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateAlarm(ServiceTarget target, SonosUpdateAlarmParameters data)
		{
			_haContext.CallService("sonos", "update_alarm", target, data);
		}

		///<summary>Updates an alarm with new time and volume settings.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="alarmId">ID for the alarm to be updated.</param>
		///<param name="time">Set time for the alarm. eg: 07:00</param>
		///<param name="volume">Set alarm volume level.</param>
		///<param name="enabled">Enable or disable the alarm.</param>
		///<param name="includeLinkedZones">Enable or disable including grouped rooms.</param>
		public void UpdateAlarm(ServiceTarget target, long @alarmId, DateTime? @time = null, double? @volume = null, bool? @enabled = null, bool? @includeLinkedZones = null)
		{
			_haContext.CallService("sonos", "update_alarm", target, new SonosUpdateAlarmParameters{AlarmId = @alarmId, Time = @time, Volume = @volume, Enabled = @enabled, IncludeLinkedZones = @includeLinkedZones});
		}
	}

	public record SonosPlayQueueParameters
	{
		///<summary>Position of the song in the queue to start playing from.</summary>
		[JsonPropertyName("queue_position")]
		public long? QueuePosition { get; init; }
	}

	public record SonosRemoveFromQueueParameters
	{
		///<summary>Position in the queue to remove.</summary>
		[JsonPropertyName("queue_position")]
		public long? QueuePosition { get; init; }
	}

	public record SonosRestoreParameters
	{
		///<summary>Name of entity that will be restored.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>True or False. Also restore the group layout.</summary>
		[JsonPropertyName("with_group")]
		public bool? WithGroup { get; init; }
	}

	public record SonosSetSleepTimerParameters
	{
		///<summary>Number of seconds to set the timer.</summary>
		[JsonPropertyName("sleep_time")]
		public long? SleepTime { get; init; }
	}

	public record SonosSnapshotParameters
	{
		///<summary>Name of entity that will be snapshot.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>True or False. Also snapshot the group layout.</summary>
		[JsonPropertyName("with_group")]
		public bool? WithGroup { get; init; }
	}

	public record SonosUpdateAlarmParameters
	{
		///<summary>ID for the alarm to be updated.</summary>
		[JsonPropertyName("alarm_id")]
		public long? AlarmId { get; init; }

		///<summary>Set time for the alarm. eg: 07:00</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>Set alarm volume level.</summary>
		[JsonPropertyName("volume")]
		public double? Volume { get; init; }

		///<summary>Enable or disable the alarm.</summary>
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; init; }

		///<summary>Enable or disable including grouped rooms.</summary>
		[JsonPropertyName("include_linked_zones")]
		public bool? IncludeLinkedZones { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TadoServices
	{
		private readonly IHaContext _haContext;
		public TadoServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the temperature offset of climate entities</summary>
		///<param name="target">The target for this service call</param>
		public void SetClimateTemperatureOffset(ServiceTarget target, TadoSetClimateTemperatureOffsetParameters data)
		{
			_haContext.CallService("tado", "set_climate_temperature_offset", target, data);
		}

		///<summary>Set the temperature offset of climate entities</summary>
		///<param name="target">The target for this service call</param>
		///<param name="offset">Offset you would like (depending on your device).</param>
		public void SetClimateTemperatureOffset(ServiceTarget target, double? @offset = null)
		{
			_haContext.CallService("tado", "set_climate_temperature_offset", target, new TadoSetClimateTemperatureOffsetParameters{Offset = @offset});
		}

		///<summary>Turn on climate entities for a set time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetClimateTimer(ServiceTarget target, TadoSetClimateTimerParameters data)
		{
			_haContext.CallService("tado", "set_climate_timer", target, data);
		}

		///<summary>Turn on climate entities for a set time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">Temperature to set climate entity to</param>
		///<param name="timePeriod">Choose this or Overlay. Set the time period for the change if you want to be specific. Alternatively use Overlay eg: 01:30:00</param>
		///<param name="requestedOverlay">Choose this or Time Period. Allows you to choose an overlay. MANUAL:=Overlay until user removes; NEXT_TIME_BLOCK:=Overlay until next timeblock; TADO_DEFAULT:=Overlay based on tado app setting eg: MANUAL</param>
		public void SetClimateTimer(ServiceTarget target, double @temperature, string? @timePeriod = null, object? @requestedOverlay = null)
		{
			_haContext.CallService("tado", "set_climate_timer", target, new TadoSetClimateTimerParameters{Temperature = @temperature, TimePeriod = @timePeriod, RequestedOverlay = @requestedOverlay});
		}

		///<summary>Turn on water heater for a set time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetWaterHeaterTimer(ServiceTarget target, TadoSetWaterHeaterTimerParameters data)
		{
			_haContext.CallService("tado", "set_water_heater_timer", target, data);
		}

		///<summary>Turn on water heater for a set time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Temperature to set heater to</param>
		public void SetWaterHeaterTimer(ServiceTarget target, string @timePeriod, double? @temperature = null)
		{
			_haContext.CallService("tado", "set_water_heater_timer", target, new TadoSetWaterHeaterTimerParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public record TadoSetClimateTemperatureOffsetParameters
	{
		///<summary>Offset you would like (depending on your device).</summary>
		[JsonPropertyName("offset")]
		public double? Offset { get; init; }
	}

	public record TadoSetClimateTimerParameters
	{
		///<summary>Temperature to set climate entity to</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>Choose this or Overlay. Set the time period for the change if you want to be specific. Alternatively use Overlay eg: 01:30:00</summary>
		[JsonPropertyName("time_period")]
		public string? TimePeriod { get; init; }

		///<summary>Choose this or Time Period. Allows you to choose an overlay. MANUAL:=Overlay until user removes; NEXT_TIME_BLOCK:=Overlay until next timeblock; TADO_DEFAULT:=Overlay based on tado app setting eg: MANUAL</summary>
		[JsonPropertyName("requested_overlay")]
		public object? RequestedOverlay { get; init; }
	}

	public record TadoSetWaterHeaterTimerParameters
	{
		///<summary>Set the time period for the boost. eg: 01:30:00</summary>
		[JsonPropertyName("time_period")]
		public string? TimePeriod { get; init; }

		///<summary>Temperature to set heater to</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleSay(TtsGoogleSayParameters data)
		{
			_haContext.CallService("tts", "google_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_say", null, new TtsGoogleSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsGoogleSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class UtilityMeterServices
	{
		private readonly IHaContext _haContext;
		public UtilityMeterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The target for this service call</param>
		public void Calibrate(ServiceTarget target, UtilityMeterCalibrateParameters data)
		{
			_haContext.CallService("utility_meter", "calibrate", target, data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public void Calibrate(ServiceTarget target, string @value)
		{
			_haContext.CallService("utility_meter", "calibrate", target, new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Resets all counters of a utility meter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("utility_meter", "reset", target);
		}
	}

	public record UtilityMeterCalibrateParameters
	{
		///<summary>Value to which set the meter eg: 100</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class VarServices
	{
		private readonly IHaContext _haContext;
		public VarServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void Reload()
		{
			_haContext.CallService("var", "reload", null);
		}

		///<summary>Set attributes of a variable entity.</summary>
		public void Set(VarSetParameters data)
		{
			_haContext.CallService("var", "set", null, data);
		}

		///<summary>Set attributes of a variable entity.</summary>
		///<param name="entityId">Entity id of the variable whose value will be set. eg: var.x</param>
		///<param name="value">The new value for the variable entity. eg: 13</param>
		///<param name="valueTemplate">The new value template for the variable entity. eg: {{ input_boolean.foo }}</param>
		///<param name="attributes">Additional attributes to set for the variable entity. eg: attr1: 42 attr2: "{{ now() }}" </param>
		///<param name="trackedEntityId">The new list of entities for the variable entity to track. eg: input_boolean.bar</param>
		///<param name="trackedEventType">The new list of event types for the variable entity to track. eg: sunset</param>
		///<param name="query">An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</param>
		///<param name="column">The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</param>
		///<param name="restore">The new restore value for the variable entity. eg: False</param>
		///<param name="forceUpdate">The new force_update value for the variable entity. eg: True</param>
		///<param name="unitOfMeasurement">The new unit of measurement for the variable entity. eg: ounces</param>
		///<param name="icon">The new icon for the variable entity. eg: mdi:baby-bottle-outline</param>
		///<param name="iconTemplate">The new icon template for the variable entity.</param>
		///<param name="entityPicture">The new picture for the variable entity. eg: local/pic.png</param>
		///<param name="entityPictureTemplate">The new picture template for the variable entity.</param>
		public void Set(object? @entityId = null, object? @value = null, object? @valueTemplate = null, object? @attributes = null, object? @trackedEntityId = null, object? @trackedEventType = null, object? @query = null, object? @column = null, object? @restore = null, object? @forceUpdate = null, object? @unitOfMeasurement = null, object? @icon = null, object? @iconTemplate = null, object? @entityPicture = null, object? @entityPictureTemplate = null)
		{
			_haContext.CallService("var", "set", null, new VarSetParameters{EntityId = @entityId, Value = @value, ValueTemplate = @valueTemplate, Attributes = @attributes, TrackedEntityId = @trackedEntityId, TrackedEventType = @trackedEventType, Query = @query, Column = @column, Restore = @restore, ForceUpdate = @forceUpdate, UnitOfMeasurement = @unitOfMeasurement, Icon = @icon, IconTemplate = @iconTemplate, EntityPicture = @entityPicture, EntityPictureTemplate = @entityPictureTemplate});
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		public void Update(VarUpdateParameters data)
		{
			_haContext.CallService("var", "update", null, data);
		}

		///<summary>Force a variable to update its state and atttributes.</summary>
		///<param name="entityId">Entity id of the variable that will be updated. eg: var.x</param>
		public void Update(object? @entityId = null)
		{
			_haContext.CallService("var", "update", null, new VarUpdateParameters{EntityId = @entityId});
		}
	}

	public record VarSetParameters
	{
		///<summary>Entity id of the variable whose value will be set. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		///<summary>The new value for the variable entity. eg: 13</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>The new value template for the variable entity. eg: {{ input_boolean.foo }}</summary>
		[JsonPropertyName("value_template")]
		public object? ValueTemplate { get; init; }

		///<summary>Additional attributes to set for the variable entity. eg: attr1: 42 attr2: "{{ now() }}" </summary>
		[JsonPropertyName("attributes")]
		public object? Attributes { get; init; }

		///<summary>The new list of entities for the variable entity to track. eg: input_boolean.bar</summary>
		[JsonPropertyName("tracked_entity_id")]
		public object? TrackedEntityId { get; init; }

		///<summary>The new list of event types for the variable entity to track. eg: sunset</summary>
		[JsonPropertyName("tracked_event_type")]
		public object? TrackedEventType { get; init; }

		///<summary>An SQL QUERY string, should return 1 result at most. eg: SELECT COUNT(*) AS todays_diaper_count FROM events WHERE event_type = 'diaper_event' AND time_fired BETWEEN DATETIME('now', 'start of day') and DATETIME('now');</summary>
		[JsonPropertyName("query")]
		public object? Query { get; init; }

		///<summary>The SQL COLUMN to select from the result of the SQL QUERY. eg: todays_diaper_count</summary>
		[JsonPropertyName("column")]
		public object? Column { get; init; }

		///<summary>The new restore value for the variable entity. eg: False</summary>
		[JsonPropertyName("restore")]
		public object? Restore { get; init; }

		///<summary>The new force_update value for the variable entity. eg: True</summary>
		[JsonPropertyName("force_update")]
		public object? ForceUpdate { get; init; }

		///<summary>The new unit of measurement for the variable entity. eg: ounces</summary>
		[JsonPropertyName("unit_of_measurement")]
		public object? UnitOfMeasurement { get; init; }

		///<summary>The new icon for the variable entity. eg: mdi:baby-bottle-outline</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>The new icon template for the variable entity.</summary>
		[JsonPropertyName("icon_template")]
		public object? IconTemplate { get; init; }

		///<summary>The new picture for the variable entity. eg: local/pic.png</summary>
		[JsonPropertyName("entity_picture")]
		public object? EntityPicture { get; init; }

		///<summary>The new picture template for the variable entity.</summary>
		[JsonPropertyName("entity_picture_template")]
		public object? EntityPictureTemplate { get; init; }
	}

	public record VarUpdateParameters
	{
		///<summary>Entity id of the variable that will be updated. eg: var.x</summary>
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }
	}

	public class WaterHeaterServices
	{
		private readonly IHaContext _haContext;
		public WaterHeaterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn away mode on/off for water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAwayMode(ServiceTarget target, WaterHeaterSetAwayModeParameters data)
		{
			_haContext.CallService("water_heater", "set_away_mode", target, data);
		}

		///<summary>Turn away mode on/off for water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="awayMode">New value of away mode.</param>
		public void SetAwayMode(ServiceTarget target, bool @awayMode)
		{
			_haContext.CallService("water_heater", "set_away_mode", target, new WaterHeaterSetAwayModeParameters{AwayMode = @awayMode});
		}

		///<summary>Set operation mode for water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOperationMode(ServiceTarget target, WaterHeaterSetOperationModeParameters data)
		{
			_haContext.CallService("water_heater", "set_operation_mode", target, data);
		}

		///<summary>Set operation mode for water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="operationMode">New value of operation mode. eg: eco</param>
		public void SetOperationMode(ServiceTarget target, string @operationMode)
		{
			_haContext.CallService("water_heater", "set_operation_mode", target, new WaterHeaterSetOperationModeParameters{OperationMode = @operationMode});
		}

		///<summary>Set target temperature of water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, WaterHeaterSetTemperatureParameters data)
		{
			_haContext.CallService("water_heater", "set_temperature", target, data);
		}

		///<summary>Set target temperature of water_heater device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for water heater.</param>
		///<param name="operationMode">New value of operation mode. eg: eco</param>
		public void SetTemperature(ServiceTarget target, double @temperature, string? @operationMode = null)
		{
			_haContext.CallService("water_heater", "set_temperature", target, new WaterHeaterSetTemperatureParameters{Temperature = @temperature, OperationMode = @operationMode});
		}

		public void TurnOff()
		{
			_haContext.CallService("water_heater", "turn_off", null);
		}

		public void TurnOn()
		{
			_haContext.CallService("water_heater", "turn_on", null);
		}
	}

	public record WaterHeaterSetAwayModeParameters
	{
		///<summary>New value of away mode.</summary>
		[JsonPropertyName("away_mode")]
		public bool? AwayMode { get; init; }
	}

	public record WaterHeaterSetOperationModeParameters
	{
		///<summary>New value of operation mode. eg: eco</summary>
		[JsonPropertyName("operation_mode")]
		public string? OperationMode { get; init; }
	}

	public record WaterHeaterSetTemperatureParameters
	{
		///<summary>New target temperature for water heater.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New value of operation mode. eg: eco</summary>
		[JsonPropertyName("operation_mode")]
		public string? OperationMode { get; init; }
	}

	public class XiaomiCloudMapExtractorServices
	{
		private readonly IHaContext _haContext;
		public XiaomiCloudMapExtractorServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all entities of Xiaomi Cloud Map Extractor platform</summary>
		public void Reload()
		{
			_haContext.CallService("xiaomi_cloud_map_extractor", "reload", null);
		}
	}

	public class XiaomiMiioServices
	{
		private readonly IHaContext _haContext;
		public XiaomiMiioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[JsonPropertyName("x_coord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[JsonPropertyName("y_coord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, object? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this IEnumerable<InputTextEntity> target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The IEnumerable<InputTextEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this IEnumerable<InputTextEntity> target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class KodiEntityExtensionMethods
	{
		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this MediaPlayerEntity target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this MediaPlayerEntity target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this MediaPlayerEntity target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this MediaPlayerEntity target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}
	}

	public static class LandroidCloudEntityExtensionMethods
	{
		///<summary>Set device config parameters</summary>
		public static void Config(this VacuumEntity target, LandroidCloudConfigParameters data)
		{
			target.CallService("config", data);
		}

		///<summary>Set device config parameters</summary>
		public static void Config(this IEnumerable<VacuumEntity> target, LandroidCloudConfigParameters data)
		{
			target.CallService("config", data);
		}

		///<summary>Set device config parameters</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="raindelay">Set rain delay. Time in minutes ranging from 0 to 300. 0 = Disabled eg: 30</param>
		///<param name="timeextension">Set time extension. Extension in % ranging from -100 to 100 eg: -23</param>
		///<param name="multizoneDistances">Set multizone distance array in meters. 0 = Disabled. Format: 15, 80, 120, 155 eg: 15, 80, 120, 155</param>
		///<param name="multizoneProbabilities">Set multizone probabilities array. Format: 50, 10, 20, 20 eg: 50, 10, 20, 20</param>
		public static void Config(this VacuumEntity target, long? @raindelay = null, long? @timeextension = null, string? @multizoneDistances = null, string? @multizoneProbabilities = null)
		{
			target.CallService("config", new LandroidCloudConfigParameters{Raindelay = @raindelay, Timeextension = @timeextension, MultizoneDistances = @multizoneDistances, MultizoneProbabilities = @multizoneProbabilities});
		}

		///<summary>Set device config parameters</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="raindelay">Set rain delay. Time in minutes ranging from 0 to 300. 0 = Disabled eg: 30</param>
		///<param name="timeextension">Set time extension. Extension in % ranging from -100 to 100 eg: -23</param>
		///<param name="multizoneDistances">Set multizone distance array in meters. 0 = Disabled. Format: 15, 80, 120, 155 eg: 15, 80, 120, 155</param>
		///<param name="multizoneProbabilities">Set multizone probabilities array. Format: 50, 10, 20, 20 eg: 50, 10, 20, 20</param>
		public static void Config(this IEnumerable<VacuumEntity> target, long? @raindelay = null, long? @timeextension = null, string? @multizoneDistances = null, string? @multizoneProbabilities = null)
		{
			target.CallService("config", new LandroidCloudConfigParameters{Raindelay = @raindelay, Timeextension = @timeextension, MultizoneDistances = @multizoneDistances, MultizoneProbabilities = @multizoneProbabilities});
		}

		///<summary>Start edgecut (if supported)</summary>
		public static void Edgecut(this VacuumEntity target)
		{
			target.CallService("edgecut");
		}

		///<summary>Start edgecut (if supported)</summary>
		public static void Edgecut(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("edgecut");
		}

		///<summary>Toggle device lock</summary>
		public static void Lock(this VacuumEntity target)
		{
			target.CallService("lock");
		}

		///<summary>Toggle device lock</summary>
		public static void Lock(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("lock");
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		public static void Ots(this VacuumEntity target, LandroidCloudOtsParameters data)
		{
			target.CallService("ots", data);
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		public static void Ots(this IEnumerable<VacuumEntity> target, LandroidCloudOtsParameters data)
		{
			target.CallService("ots", data);
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="boundary">Do boundary (Edge cut) eg: True</param>
		///<param name="runtime">Run time in minutes eg: 60</param>
		public static void Ots(this VacuumEntity target, bool @boundary, long @runtime)
		{
			target.CallService("ots", new LandroidCloudOtsParameters{Boundary = @boundary, Runtime = @runtime});
		}

		///<summary>Start One-Time-Schedule (if supported)</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="boundary">Do boundary (Edge cut) eg: True</param>
		///<param name="runtime">Run time in minutes eg: 60</param>
		public static void Ots(this IEnumerable<VacuumEntity> target, bool @boundary, long @runtime)
		{
			target.CallService("ots", new LandroidCloudOtsParameters{Boundary = @boundary, Runtime = @runtime});
		}

		///<summary>Toggle PartyMode (if supported)</summary>
		public static void Partymode(this VacuumEntity target)
		{
			target.CallService("partymode");
		}

		///<summary>Toggle PartyMode (if supported)</summary>
		public static void Partymode(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("partymode");
		}

		///<summary>Send a refresh request to the API endpoint - ONLY USE FOR RARE CASES</summary>
		public static void Refresh(this VacuumEntity target)
		{
			target.CallService("refresh");
		}

		///<summary>Send a refresh request to the API endpoint - ONLY USE FOR RARE CASES</summary>
		public static void Refresh(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("refresh");
		}

		///<summary>Restart device</summary>
		public static void Restart(this VacuumEntity target)
		{
			target.CallService("restart");
		}

		///<summary>Restart device</summary>
		public static void Restart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("restart");
		}

		///<summary>Set or change the schedule of the mower</summary>
		public static void Schedule(this VacuumEntity target, LandroidCloudScheduleParameters data)
		{
			target.CallService("schedule", data);
		}

		///<summary>Set or change the schedule of the mower</summary>
		public static void Schedule(this IEnumerable<VacuumEntity> target, LandroidCloudScheduleParameters data)
		{
			target.CallService("schedule", data);
		}

		///<summary>Set or change the schedule of the mower</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="type">Change primary or secondary schedule? eg: primary</param>
		///<param name="mondayStart">Starting time for monday eg: 11:00</param>
		///<param name="mondayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="mondayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="tuesdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="tuesdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="tuesdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="wednesdayStart">Starting time for monday eg: 11:00</param>
		///<param name="wednesdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="wednesdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="thursdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="thursdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="thursdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="fridayStart">When should the device start the task? eg: 11:00</param>
		///<param name="fridayEnd">When should the task stop? eg: 16:00</param>
		///<param name="fridayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="saturdayStart">Starting time for monday eg: 11:00</param>
		///<param name="saturdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="saturdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="sundayStart">When should the device start the task? eg: 11:00</param>
		///<param name="sundayEnd">When should the task stop? eg: 16:00</param>
		///<param name="sundayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		public static void Schedule(this VacuumEntity target, object @type, DateTime? @mondayStart = null, DateTime? @mondayEnd = null, bool? @mondayBoundary = null, DateTime? @tuesdayStart = null, DateTime? @tuesdayEnd = null, bool? @tuesdayBoundary = null, DateTime? @wednesdayStart = null, DateTime? @wednesdayEnd = null, bool? @wednesdayBoundary = null, DateTime? @thursdayStart = null, DateTime? @thursdayEnd = null, bool? @thursdayBoundary = null, DateTime? @fridayStart = null, DateTime? @fridayEnd = null, bool? @fridayBoundary = null, DateTime? @saturdayStart = null, DateTime? @saturdayEnd = null, bool? @saturdayBoundary = null, DateTime? @sundayStart = null, DateTime? @sundayEnd = null, bool? @sundayBoundary = null)
		{
			target.CallService("schedule", new LandroidCloudScheduleParameters{Type = @type, MondayStart = @mondayStart, MondayEnd = @mondayEnd, MondayBoundary = @mondayBoundary, TuesdayStart = @tuesdayStart, TuesdayEnd = @tuesdayEnd, TuesdayBoundary = @tuesdayBoundary, WednesdayStart = @wednesdayStart, WednesdayEnd = @wednesdayEnd, WednesdayBoundary = @wednesdayBoundary, ThursdayStart = @thursdayStart, ThursdayEnd = @thursdayEnd, ThursdayBoundary = @thursdayBoundary, FridayStart = @fridayStart, FridayEnd = @fridayEnd, FridayBoundary = @fridayBoundary, SaturdayStart = @saturdayStart, SaturdayEnd = @saturdayEnd, SaturdayBoundary = @saturdayBoundary, SundayStart = @sundayStart, SundayEnd = @sundayEnd, SundayBoundary = @sundayBoundary});
		}

		///<summary>Set or change the schedule of the mower</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="type">Change primary or secondary schedule? eg: primary</param>
		///<param name="mondayStart">Starting time for monday eg: 11:00</param>
		///<param name="mondayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="mondayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="tuesdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="tuesdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="tuesdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="wednesdayStart">Starting time for monday eg: 11:00</param>
		///<param name="wednesdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="wednesdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="thursdayStart">When should the device start the task? eg: 11:00</param>
		///<param name="thursdayEnd">When should the task stop? eg: 16:00</param>
		///<param name="thursdayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="fridayStart">When should the device start the task? eg: 11:00</param>
		///<param name="fridayEnd">When should the task stop? eg: 16:00</param>
		///<param name="fridayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		///<param name="saturdayStart">Starting time for monday eg: 11:00</param>
		///<param name="saturdayEnd">When should the schedule stop on mondays? eg: 16:00</param>
		///<param name="saturdayBoundary">Should we start this schedule by cutting the boundary (edge cut)? eg: False</param>
		///<param name="sundayStart">When should the device start the task? eg: 11:00</param>
		///<param name="sundayEnd">When should the task stop? eg: 16:00</param>
		///<param name="sundayBoundary">Should we start this task by cutting the boundary (edge cut)? eg: False</param>
		public static void Schedule(this IEnumerable<VacuumEntity> target, object @type, DateTime? @mondayStart = null, DateTime? @mondayEnd = null, bool? @mondayBoundary = null, DateTime? @tuesdayStart = null, DateTime? @tuesdayEnd = null, bool? @tuesdayBoundary = null, DateTime? @wednesdayStart = null, DateTime? @wednesdayEnd = null, bool? @wednesdayBoundary = null, DateTime? @thursdayStart = null, DateTime? @thursdayEnd = null, bool? @thursdayBoundary = null, DateTime? @fridayStart = null, DateTime? @fridayEnd = null, bool? @fridayBoundary = null, DateTime? @saturdayStart = null, DateTime? @saturdayEnd = null, bool? @saturdayBoundary = null, DateTime? @sundayStart = null, DateTime? @sundayEnd = null, bool? @sundayBoundary = null)
		{
			target.CallService("schedule", new LandroidCloudScheduleParameters{Type = @type, MondayStart = @mondayStart, MondayEnd = @mondayEnd, MondayBoundary = @mondayBoundary, TuesdayStart = @tuesdayStart, TuesdayEnd = @tuesdayEnd, TuesdayBoundary = @tuesdayBoundary, WednesdayStart = @wednesdayStart, WednesdayEnd = @wednesdayEnd, WednesdayBoundary = @wednesdayBoundary, ThursdayStart = @thursdayStart, ThursdayEnd = @thursdayEnd, ThursdayBoundary = @thursdayBoundary, FridayStart = @fridayStart, FridayEnd = @fridayEnd, FridayBoundary = @fridayBoundary, SaturdayStart = @saturdayStart, SaturdayEnd = @saturdayEnd, SaturdayBoundary = @saturdayBoundary, SundayStart = @sundayStart, SundayEnd = @sundayEnd, SundayBoundary = @sundayBoundary});
		}

		///<summary>Send a raw JSON command to the device</summary>
		public static void SendRaw(this VacuumEntity target, LandroidCloudSendRawParameters data)
		{
			target.CallService("send_raw", data);
		}

		///<summary>Send a raw JSON command to the device</summary>
		public static void SendRaw(this IEnumerable<VacuumEntity> target, LandroidCloudSendRawParameters data)
		{
			target.CallService("send_raw", data);
		}

		///<summary>Send a raw JSON command to the device</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="json">Data to send, formatted as valid JSON eg: {'cmd': 1}</param>
		public static void SendRaw(this VacuumEntity target, string @json)
		{
			target.CallService("send_raw", new LandroidCloudSendRawParameters{Json = @json});
		}

		///<summary>Send a raw JSON command to the device</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="json">Data to send, formatted as valid JSON eg: {'cmd': 1}</param>
		public static void SendRaw(this IEnumerable<VacuumEntity> target, string @json)
		{
			target.CallService("send_raw", new LandroidCloudSendRawParameters{Json = @json});
		}

		///<summary>Set which zone to be mowed next</summary>
		public static void Setzone(this VacuumEntity target, LandroidCloudSetzoneParameters data)
		{
			target.CallService("setzone", data);
		}

		///<summary>Set which zone to be mowed next</summary>
		public static void Setzone(this IEnumerable<VacuumEntity> target, LandroidCloudSetzoneParameters data)
		{
			target.CallService("setzone", data);
		}

		///<summary>Set which zone to be mowed next</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Sets the zone number, ranging from 0 to 3, to be mowed next eg: 1</param>
		public static void Setzone(this VacuumEntity target, object @zone)
		{
			target.CallService("setzone", new LandroidCloudSetzoneParameters{Zone = @zone});
		}

		///<summary>Set which zone to be mowed next</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Sets the zone number, ranging from 0 to 3, to be mowed next eg: 1</param>
		public static void Setzone(this IEnumerable<VacuumEntity> target, object @zone)
		{
			target.CallService("setzone", new LandroidCloudSetzoneParameters{Zone = @zone});
		}

		///<summary>Set wheel torque</summary>
		public static void Torque(this VacuumEntity target, LandroidCloudTorqueParameters data)
		{
			target.CallService("torque", data);
		}

		///<summary>Set wheel torque</summary>
		public static void Torque(this IEnumerable<VacuumEntity> target, LandroidCloudTorqueParameters data)
		{
			target.CallService("torque", data);
		}

		///<summary>Set wheel torque</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="torque">Set wheel torque. Ranging from -50% to 50% eg: 22</param>
		public static void Torque(this VacuumEntity target, long @torque)
		{
			target.CallService("torque", new LandroidCloudTorqueParameters{Torque = @torque});
		}

		///<summary>Set wheel torque</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="torque">Set wheel torque. Ranging from -50% to 50% eg: 22</param>
		public static void Torque(this IEnumerable<VacuumEntity> target, long @torque)
		{
			target.CallService("torque", new LandroidCloudTorqueParameters{Torque = @torque});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this MediaPlayerEntity target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: - media_player.multiroom_player2 - media_player.multiroom_player3 </param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, string @groupMembers)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TadoEntityExtensionMethods
	{
		///<summary>Set the temperature offset of climate entities</summary>
		public static void SetClimateTemperatureOffset(this ClimateEntity target, TadoSetClimateTemperatureOffsetParameters data)
		{
			target.CallService("set_climate_temperature_offset", data);
		}

		///<summary>Set the temperature offset of climate entities</summary>
		public static void SetClimateTemperatureOffset(this IEnumerable<ClimateEntity> target, TadoSetClimateTemperatureOffsetParameters data)
		{
			target.CallService("set_climate_temperature_offset", data);
		}

		///<summary>Set the temperature offset of climate entities</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="offset">Offset you would like (depending on your device).</param>
		public static void SetClimateTemperatureOffset(this ClimateEntity target, double? @offset = null)
		{
			target.CallService("set_climate_temperature_offset", new TadoSetClimateTemperatureOffsetParameters{Offset = @offset});
		}

		///<summary>Set the temperature offset of climate entities</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="offset">Offset you would like (depending on your device).</param>
		public static void SetClimateTemperatureOffset(this IEnumerable<ClimateEntity> target, double? @offset = null)
		{
			target.CallService("set_climate_temperature_offset", new TadoSetClimateTemperatureOffsetParameters{Offset = @offset});
		}

		///<summary>Turn on climate entities for a set time.</summary>
		public static void SetClimateTimer(this ClimateEntity target, TadoSetClimateTimerParameters data)
		{
			target.CallService("set_climate_timer", data);
		}

		///<summary>Turn on climate entities for a set time.</summary>
		public static void SetClimateTimer(this IEnumerable<ClimateEntity> target, TadoSetClimateTimerParameters data)
		{
			target.CallService("set_climate_timer", data);
		}

		///<summary>Turn on climate entities for a set time.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">Temperature to set climate entity to</param>
		///<param name="timePeriod">Choose this or Overlay. Set the time period for the change if you want to be specific. Alternatively use Overlay eg: 01:30:00</param>
		///<param name="requestedOverlay">Choose this or Time Period. Allows you to choose an overlay. MANUAL:=Overlay until user removes; NEXT_TIME_BLOCK:=Overlay until next timeblock; TADO_DEFAULT:=Overlay based on tado app setting eg: MANUAL</param>
		public static void SetClimateTimer(this ClimateEntity target, double @temperature, string? @timePeriod = null, object? @requestedOverlay = null)
		{
			target.CallService("set_climate_timer", new TadoSetClimateTimerParameters{Temperature = @temperature, TimePeriod = @timePeriod, RequestedOverlay = @requestedOverlay});
		}

		///<summary>Turn on climate entities for a set time.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">Temperature to set climate entity to</param>
		///<param name="timePeriod">Choose this or Overlay. Set the time period for the change if you want to be specific. Alternatively use Overlay eg: 01:30:00</param>
		///<param name="requestedOverlay">Choose this or Time Period. Allows you to choose an overlay. MANUAL:=Overlay until user removes; NEXT_TIME_BLOCK:=Overlay until next timeblock; TADO_DEFAULT:=Overlay based on tado app setting eg: MANUAL</param>
		public static void SetClimateTimer(this IEnumerable<ClimateEntity> target, double @temperature, string? @timePeriod = null, object? @requestedOverlay = null)
		{
			target.CallService("set_climate_timer", new TadoSetClimateTimerParameters{Temperature = @temperature, TimePeriod = @timePeriod, RequestedOverlay = @requestedOverlay});
		}

		///<summary>Turn on water heater for a set time.</summary>
		public static void SetWaterHeaterTimer(this ClimateEntity target, TadoSetWaterHeaterTimerParameters data)
		{
			target.CallService("set_water_heater_timer", data);
		}

		///<summary>Turn on water heater for a set time.</summary>
		public static void SetWaterHeaterTimer(this IEnumerable<ClimateEntity> target, TadoSetWaterHeaterTimerParameters data)
		{
			target.CallService("set_water_heater_timer", data);
		}

		///<summary>Turn on water heater for a set time.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Temperature to set heater to</param>
		public static void SetWaterHeaterTimer(this ClimateEntity target, string @timePeriod, double? @temperature = null)
		{
			target.CallService("set_water_heater_timer", new TadoSetWaterHeaterTimerParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}

		///<summary>Turn on water heater for a set time.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="timePeriod">Set the time period for the boost. eg: 01:30:00</param>
		///<param name="temperature">Temperature to set heater to</param>
		public static void SetWaterHeaterTimer(this IEnumerable<ClimateEntity> target, string @timePeriod, double? @temperature = null)
		{
			target.CallService("set_water_heater_timer", new TadoSetWaterHeaterTimerParameters{TimePeriod = @timePeriod, Temperature = @temperature});
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}

	public static class UtilityMeterEntityExtensionMethods
	{
		///<summary>Calibrates a utility meter sensor.</summary>
		public static void Calibrate(this SensorEntity target, UtilityMeterCalibrateParameters data)
		{
			target.CallService("calibrate", data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		public static void Calibrate(this IEnumerable<SensorEntity> target, UtilityMeterCalibrateParameters data)
		{
			target.CallService("calibrate", data);
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public static void Calibrate(this SensorEntity target, string @value)
		{
			target.CallService("calibrate", new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Calibrates a utility meter sensor.</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="value">Value to which set the meter eg: 100</param>
		public static void Calibrate(this IEnumerable<SensorEntity> target, string @value)
		{
			target.CallService("calibrate", new UtilityMeterCalibrateParameters{Value = @value});
		}

		///<summary>Resets all counters of a utility meter.</summary>
		public static void Reset(this SelectEntity target)
		{
			target.CallService("reset");
		}

		///<summary>Resets all counters of a utility meter.</summary>
		public static void Reset(this IEnumerable<SelectEntity> target)
		{
			target.CallService("reset");
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_stop");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_stop");
		}
	}
}