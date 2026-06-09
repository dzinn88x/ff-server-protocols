using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	[ProtoContract]
	public class LoginReq
	{
		// Token: 0x060025AB RID: 9643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0x21BBE8C", Offset = "0x21BBE8C", VA = "0x7BBC9BBE8C")]
		public LoginReq()
		{
		}

		// Token: 0x040028FC RID: 10492
		[Token(Token = "0x40028FC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113E48", Offset = "0x1113E48")]
		public ulong account_id;

		// Token: 0x040028FD RID: 10493
		[Token(Token = "0x40028FD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113E5C", Offset = "0x1113E5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113E5C", Offset = "0x1113E5C")]
		public string game_server_id;

		// Token: 0x040028FE RID: 10494
		[Token(Token = "0x40028FE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113EAC", Offset = "0x1113EAC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113EAC", Offset = "0x1113EAC")]
		public string event_time;

		// Token: 0x040028FF RID: 10495
		[Token(Token = "0x40028FF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113EFC", Offset = "0x1113EFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113EFC", Offset = "0x1113EFC")]
		public string game_id;

		// Token: 0x04002900 RID: 10496
		[Token(Token = "0x4002900")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113F4C", Offset = "0x1113F4C")]
		public uint plat_id;

		// Token: 0x04002901 RID: 10497
		[Token(Token = "0x4002901")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113F60", Offset = "0x1113F60")]
		public uint zone_area_id;

		// Token: 0x04002902 RID: 10498
		[Token(Token = "0x4002902")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113F74", Offset = "0x1113F74")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113F74", Offset = "0x1113F74")]
		public string client_version;

		// Token: 0x04002903 RID: 10499
		[Token(Token = "0x4002903")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113FC4", Offset = "0x1113FC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1113FC4", Offset = "0x1113FC4")]
		public string system_software;

		// Token: 0x04002904 RID: 10500
		[Token(Token = "0x4002904")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114014", Offset = "0x1114014")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114014", Offset = "0x1114014")]
		public string system_hardware;

		// Token: 0x04002905 RID: 10501
		[Token(Token = "0x4002905")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114064", Offset = "0x1114064")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114064", Offset = "0x1114064")]
		public string telecom_oper;

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11140B4", Offset = "0x11140B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11140B4", Offset = "0x11140B4")]
		public string network;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114104", Offset = "0x1114104")]
		public uint screen_width;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114118", Offset = "0x1114118")]
		public uint screen_hight;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111412C", Offset = "0x111412C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111412C", Offset = "0x111412C")]
		public string dpi;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111417C", Offset = "0x111417C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111417C", Offset = "0x111417C")]
		public string cpu_hardware;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11141CC", Offset = "0x11141CC")]
		public uint memory;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11141E0", Offset = "0x11141E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11141E0", Offset = "0x11141E0")]
		public string gl_render;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114230", Offset = "0x1114230")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114230", Offset = "0x1114230")]
		public string gl_version;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114280", Offset = "0x1114280")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114280", Offset = "0x1114280")]
		public string device_id;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11142D0", Offset = "0x11142D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11142D0", Offset = "0x11142D0")]
		public string client_ip;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114320", Offset = "0x1114320")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114320", Offset = "0x1114320")]
		public string language;

		// Token: 0x04002911 RID: 10513
		[Token(Token = "0x4002911")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114370", Offset = "0x1114370")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114370", Offset = "0x1114370")]
		public string open_id;

		// Token: 0x04002912 RID: 10514
		[Token(Token = "0x4002912")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11143C0", Offset = "0x11143C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11143C0", Offset = "0x11143C0")]
		public string open_id_type;

		// Token: 0x04002913 RID: 10515
		[Token(Token = "0x4002913")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114410", Offset = "0x1114410")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114410", Offset = "0x1114410")]
		public string device_type;

		// Token: 0x04002914 RID: 10516
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114460", Offset = "0x1114460")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114460", Offset = "0x1114460")]
		public string device_model;

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11144B0", Offset = "0x11144B0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11144B0", Offset = "0x11144B0")]
		public string region;

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114500", Offset = "0x1114500")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114500", Offset = "0x1114500")]
		public string ip_region;

		// Token: 0x04002917 RID: 10519
		[Token(Token = "0x4002917")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114550", Offset = "0x1114550")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114550", Offset = "0x1114550")]
		public string others;

		// Token: 0x04002918 RID: 10520
		[Token(Token = "0x4002918")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11145A0", Offset = "0x11145A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11145A0", Offset = "0x11145A0")]
		public string login_token;

		// Token: 0x04002919 RID: 10521
		[Token(Token = "0x4002919")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11145F0", Offset = "0x11145F0")]
		public uint platform_sdk_id;

		// Token: 0x0400291A RID: 10522
		[Token(Token = "0x400291A")]
		[FieldOffset(Offset = "0xEC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114604", Offset = "0x1114604")]
		public uint level;

		// Token: 0x0400291B RID: 10523
		[Token(Token = "0x400291B")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114618", Offset = "0x1114618")]
		public ulong clan_id;

		// Token: 0x0400291C RID: 10524
		[Token(Token = "0x400291C")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111462C", Offset = "0x111462C")]
		public ulong platform_uid;

		// Token: 0x0400291D RID: 10525
		[Token(Token = "0x400291D")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114640", Offset = "0x1114640")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114640", Offset = "0x1114640")]
		public string nickname;

		// Token: 0x0400291E RID: 10526
		[Token(Token = "0x400291E")]
		[FieldOffset(Offset = "0x108")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114690", Offset = "0x1114690")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114690", Offset = "0x1114690")]
		public string serial_a;

		// Token: 0x0400291F RID: 10527
		[Token(Token = "0x400291F")]
		[FieldOffset(Offset = "0x110")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11146E0", Offset = "0x11146E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11146E0", Offset = "0x11146E0")]
		public string board_a;

		// Token: 0x04002920 RID: 10528
		[Token(Token = "0x4002920")]
		[FieldOffset(Offset = "0x118")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114730", Offset = "0x1114730")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114730", Offset = "0x1114730")]
		public string brand_a;

		// Token: 0x04002921 RID: 10529
		[Token(Token = "0x4002921")]
		[FieldOffset(Offset = "0x120")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114780", Offset = "0x1114780")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114780", Offset = "0x1114780")]
		public string fingerprint_a;

		// Token: 0x04002922 RID: 10530
		[Token(Token = "0x4002922")]
		[FieldOffset(Offset = "0x128")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11147D0", Offset = "0x11147D0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11147D0", Offset = "0x11147D0")]
		public string hardware_a;

		// Token: 0x04002923 RID: 10531
		[Token(Token = "0x4002923")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114820", Offset = "0x1114820")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114820", Offset = "0x1114820")]
		public string manufacturer_a;

		// Token: 0x04002924 RID: 10532
		[Token(Token = "0x4002924")]
		[FieldOffset(Offset = "0x138")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114870", Offset = "0x1114870")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114870", Offset = "0x1114870")]
		public string network_operator_a;

		// Token: 0x04002925 RID: 10533
		[Token(Token = "0x4002925")]
		[FieldOffset(Offset = "0x140")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11148C0", Offset = "0x11148C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11148C0", Offset = "0x11148C0")]
		public string network_type_a;

		// Token: 0x04002926 RID: 10534
		[Token(Token = "0x4002926")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114910", Offset = "0x1114910")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114910", Offset = "0x1114910")]
		public string imei_a;

		// Token: 0x04002927 RID: 10535
		[Token(Token = "0x4002927")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114960", Offset = "0x1114960")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114960", Offset = "0x1114960")]
		public string meid_a;

		// Token: 0x04002928 RID: 10536
		[Token(Token = "0x4002928")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11149B0", Offset = "0x11149B0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11149B0", Offset = "0x11149B0")]
		public string subscriber_a;

		// Token: 0x04002929 RID: 10537
		[Token(Token = "0x4002929")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114A00", Offset = "0x1114A00")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114A00", Offset = "0x1114A00")]
		public string line_1_num_a;

		// Token: 0x0400292A RID: 10538
		[Token(Token = "0x400292A")]
		[FieldOffset(Offset = "0x168")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114A50", Offset = "0x1114A50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114A50", Offset = "0x1114A50")]
		public string device_a;

		// Token: 0x0400292B RID: 10539
		[Token(Token = "0x400292B")]
		[FieldOffset(Offset = "0x170")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114AA0", Offset = "0x1114AA0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114AA0", Offset = "0x1114AA0")]
		public string product_a;

		// Token: 0x0400292C RID: 10540
		[Token(Token = "0x400292C")]
		[FieldOffset(Offset = "0x178")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114AF0", Offset = "0x1114AF0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114AF0", Offset = "0x1114AF0")]
		public string model_a;

		// Token: 0x0400292D RID: 10541
		[Token(Token = "0x400292D")]
		[FieldOffset(Offset = "0x180")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114B40", Offset = "0x1114B40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114B40", Offset = "0x1114B40")]
		public string bootloader_a;

		// Token: 0x0400292E RID: 10542
		[Token(Token = "0x400292E")]
		[FieldOffset(Offset = "0x188")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114B90", Offset = "0x1114B90")]
		public ulong check_emulator_files_list_a;

		// Token: 0x0400292F RID: 10543
		[Token(Token = "0x400292F")]
		[FieldOffset(Offset = "0x190")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114BA4", Offset = "0x1114BA4")]
		public ulong check_emulator_properties_list_a;

		// Token: 0x04002930 RID: 10544
		[Token(Token = "0x4002930")]
		[FieldOffset(Offset = "0x198")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114BB8", Offset = "0x1114BB8")]
		public ulong check_emulator_package_list_a;

		// Token: 0x04002931 RID: 10545
		[Token(Token = "0x4002931")]
		[FieldOffset(Offset = "0x1A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114BCC", Offset = "0x1114BCC")]
		public bool is_emulator;

		// Token: 0x04002932 RID: 10546
		[Token(Token = "0x4002932")]
		[FieldOffset(Offset = "0x1A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114BE0", Offset = "0x1114BE0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114BE0", Offset = "0x1114BE0")]
		public string ip_address;

		// Token: 0x04002933 RID: 10547
		[Token(Token = "0x4002933")]
		[FieldOffset(Offset = "0x1B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114C30", Offset = "0x1114C30")]
		public bool is_root;

		// Token: 0x04002934 RID: 10548
		[Token(Token = "0x4002934")]
		[FieldOffset(Offset = "0x1B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114C44", Offset = "0x1114C44")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114C44", Offset = "0x1114C44")]
		public string signature_md5;

		// Token: 0x04002935 RID: 10549
		[Token(Token = "0x4002935")]
		[FieldOffset(Offset = "0x1C0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114C94", Offset = "0x1114C94")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114C94", Offset = "0x1114C94")]
		public string sensor_info;

		// Token: 0x04002936 RID: 10550
		[Token(Token = "0x4002936")]
		[FieldOffset(Offset = "0x1C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114CE4", Offset = "0x1114CE4")]
		public uint emulator_score;

		// Token: 0x04002937 RID: 10551
		[Token(Token = "0x4002937")]
		[FieldOffset(Offset = "0x1CC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114CF8", Offset = "0x1114CF8")]
		public int sdcard_total_storage;

		// Token: 0x04002938 RID: 10552
		[Token(Token = "0x4002938")]
		[FieldOffset(Offset = "0x1D0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D0C", Offset = "0x1114D0C")]
		public int sdcard_avail_storage;

		// Token: 0x04002939 RID: 10553
		[Token(Token = "0x4002939")]
		[FieldOffset(Offset = "0x1D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D20", Offset = "0x1114D20")]
		public int inner_total_storage;

		// Token: 0x0400293A RID: 10554
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x1D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D34", Offset = "0x1114D34")]
		public int inner_avail_storage;

		// Token: 0x0400293B RID: 10555
		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x1DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D48", Offset = "0x1114D48")]
		public int game_installed_disk_avail_storage;

		// Token: 0x0400293C RID: 10556
		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x1E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D5C", Offset = "0x1114D5C")]
		public int game_installed_disk_total_storage;

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x1E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D70", Offset = "0x1114D70")]
		public int external_sdcard_avail_storage;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x1E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D84", Offset = "0x1114D84")]
		public int external_sdcard_total_storage;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x1EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114D98", Offset = "0x1114D98")]
		public uint login_by;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x1F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114DAC", Offset = "0x1114DAC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114DAC", Offset = "0x1114DAC")]
		public string noti_region;

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x1F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114DFC", Offset = "0x1114DFC")]
		public EAccount.DownloadType source;

		// Token: 0x04002942 RID: 10562
		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x1FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114E10", Offset = "0x1114E10")]
		public uint reg_avatar;

		// Token: 0x04002943 RID: 10563
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x200")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114E24", Offset = "0x1114E24")]
		public uint lock_region_time;

		// Token: 0x04002944 RID: 10564
		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x204")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114E38", Offset = "0x1114E38")]
		public uint quality;

		// Token: 0x04002945 RID: 10565
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x208")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114E4C", Offset = "0x1114E4C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114E4C", Offset = "0x1114E4C")]
		public string lib_path;

		// Token: 0x04002946 RID: 10566
		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x210")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114E9C", Offset = "0x1114E9C")]
		public EAntiAddiction.AgeState age_state;

		// Token: 0x04002947 RID: 10567
		[Token(Token = "0x4002947")]
		[FieldOffset(Offset = "0x214")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114EB0", Offset = "0x1114EB0")]
		public EAuth.ClientUsingVersion using_version;

		// Token: 0x04002948 RID: 10568
		[Token(Token = "0x4002948")]
		[FieldOffset(Offset = "0x218")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114EC4", Offset = "0x1114EC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114EC4", Offset = "0x1114EC4")]
		public string lib_token;

		// Token: 0x04002949 RID: 10569
		[Token(Token = "0x4002949")]
		[FieldOffset(Offset = "0x220")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114F14", Offset = "0x1114F14")]
		public uint channel_type;

		// Token: 0x0400294A RID: 10570
		[Token(Token = "0x400294A")]
		[FieldOffset(Offset = "0x224")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114F28", Offset = "0x1114F28")]
		public uint cpu_type;

		// Token: 0x0400294B RID: 10571
		[Token(Token = "0x400294B")]
		[FieldOffset(Offset = "0x228")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114F3C", Offset = "0x1114F3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114F3C", Offset = "0x1114F3C")]
		public string cpu_architecture;

		// Token: 0x0400294C RID: 10572
		[Token(Token = "0x400294C")]
		[FieldOffset(Offset = "0x230")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114F8C", Offset = "0x1114F8C")]
		public byte[] mtp_detail;

		// Token: 0x0400294D RID: 10573
		[Token(Token = "0x400294D")]
		[FieldOffset(Offset = "0x238")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114FA0", Offset = "0x1114FA0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1114FA0", Offset = "0x1114FA0")]
		public string client_version_code;

		// Token: 0x0400294E RID: 10574
		[Token(Token = "0x400294E")]
		[FieldOffset(Offset = "0x240")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1114FF0", Offset = "0x1114FF0")]
		public long token_expires_at;
	}
}
