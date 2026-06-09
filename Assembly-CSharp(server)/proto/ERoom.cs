using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000679 RID: 1657
	[Token(Token = "0x2000679")]
	[ProtoContract]
	public class ERoom
	{
		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x21B9B34", Offset = "0x21B9B34", VA = "0x7BBC9B9B34")]
		public ERoom()
		{
		}

		// Token: 0x0200067A RID: 1658
		[Token(Token = "0x200067A")]
		[ProtoContract]
		public enum Cmd
		{
			// Token: 0x04002098 RID: 8344
			[Token(Token = "0x4002098")]
			Cmd_NONE,
			// Token: 0x04002099 RID: 8345
			[Token(Token = "0x4002099")]
			Cmd_SEND_ALL_ROOMS,
			// Token: 0x0400209A RID: 8346
			[Token(Token = "0x400209A")]
			Cmd_OK
		}

		// Token: 0x0200067B RID: 1659
		[Token(Token = "0x200067B")]
		[ProtoContract]
		public enum ChangeMatchInfoEvent
		{
			// Token: 0x0400209C RID: 8348
			[Token(Token = "0x400209C")]
			ChangeMatchInfoEvent_NONE,
			// Token: 0x0400209D RID: 8349
			[Token(Token = "0x400209D")]
			ChangeMatchInfoEvent_CHOOSELOADOUTS,
			// Token: 0x0400209E RID: 8350
			[Token(Token = "0x400209E")]
			ChangeMatchInfoEvent_CHOOSECLOTHES,
			// Token: 0x0400209F RID: 8351
			[Token(Token = "0x400209F")]
			ChangeMatchInfoEvent_EQUIPSKILLS
		}

		// Token: 0x0200067C RID: 1660
		[Token(Token = "0x200067C")]
		[ProtoContract]
		public enum DropPresetState
		{
			// Token: 0x040020A1 RID: 8353
			[Token(Token = "0x40020A1")]
			DropPresetState_DEFAULT_OFF_FUNC_OPEN,
			// Token: 0x040020A2 RID: 8354
			[Token(Token = "0x40020A2")]
			DropPresetState_DEFAULT_ON_FUNC_OPEN,
			// Token: 0x040020A3 RID: 8355
			[Token(Token = "0x40020A3")]
			DropPresetState_DEFAULT_OFF_FUNC_CLOSE,
			// Token: 0x040020A4 RID: 8356
			[Token(Token = "0x40020A4")]
			DropPresetState_DEFAULT_ON_FUNC_CLOSE
		}

		// Token: 0x0200067D RID: 1661
		[Token(Token = "0x200067D")]
		[ProtoContract]
		public enum WeatherType
		{
			// Token: 0x040020A6 RID: 8358
			[Token(Token = "0x40020A6")]
			WeatherType_NONE,
			// Token: 0x040020A7 RID: 8359
			[Token(Token = "0x40020A7")]
			WeatherType_DAY,
			// Token: 0x040020A8 RID: 8360
			[Token(Token = "0x40020A8")]
			WeatherType_NIGHT
		}

		// Token: 0x0200067E RID: 1662
		[Token(Token = "0x200067E")]
		[ProtoContract]
		public enum CustomRoomSetting
		{
			// Token: 0x040020AA RID: 8362
			[Token(Token = "0x40020AA")]
			CustomRoomSetting_HIDEKILLINFO,
			// Token: 0x040020AB RID: 8363
			[Token(Token = "0x40020AB")]
			CustomRoomSetting_UNLIMITEDAMMO,
			// Token: 0x040020AC RID: 8364
			[Token(Token = "0x40020AC")]
			CustomRoomSetting_NOFALLINGDAMAGE,
			// Token: 0x040020AD RID: 8365
			[Token(Token = "0x40020AD")]
			CustomRoomSetting_NOLOADOUT,
			// Token: 0x040020AE RID: 8366
			[Token(Token = "0x40020AE")]
			CustomRoomSetting_NOAIRDROP,
			// Token: 0x040020AF RID: 8367
			[Token(Token = "0x40020AF")]
			CustomRoomSetting_NOSKILL,
			// Token: 0x040020B0 RID: 8368
			[Token(Token = "0x40020B0")]
			CustomRoomSetting_NOVEHICLE,
			// Token: 0x040020B1 RID: 8369
			[Token(Token = "0x40020B1")]
			CustomRoomSetting_PLAYERHP_START = 8,
			// Token: 0x040020B2 RID: 8370
			[Token(Token = "0x40020B2")]
			CustomRoomSetting_PLAYERHP_END = 10,
			// Token: 0x040020B3 RID: 8371
			[Token(Token = "0x40020B3")]
			CustomRoomSetting_PLAYEREP_START,
			// Token: 0x040020B4 RID: 8372
			[Token(Token = "0x40020B4")]
			CustomRoomSetting_PLAYEREP_END = 13,
			// Token: 0x040020B5 RID: 8373
			[Token(Token = "0x40020B5")]
			CustomRoomSetting_PLAYERSPEED_START,
			// Token: 0x040020B6 RID: 8374
			[Token(Token = "0x40020B6")]
			CustomRoomSetting_PLAYERSPEED_END = 16,
			// Token: 0x040020B7 RID: 8375
			[Token(Token = "0x40020B7")]
			CustomRoomSetting_DROPLIST_START,
			// Token: 0x040020B8 RID: 8376
			[Token(Token = "0x40020B8")]
			CustomRoomSetting_DROPLIST_END = 20,
			// Token: 0x040020B9 RID: 8377
			[Token(Token = "0x40020B9")]
			CustomRoomSetting_PLAYERJUMPHEIGHT_START,
			// Token: 0x040020BA RID: 8378
			[Token(Token = "0x40020BA")]
			CustomRoomSetting_PLAYERJUMPHEIGHT_END = 23,
			// Token: 0x040020BB RID: 8379
			[Token(Token = "0x40020BB")]
			CustomRoomSetting_ACCTOTALSTATS,
			// Token: 0x040020BC RID: 8380
			[Token(Token = "0x40020BC")]
			CustomRoomSetting_ROUNDNUM_START,
			// Token: 0x040020BD RID: 8381
			[Token(Token = "0x40020BD")]
			CustomRoomSetting_ROUNDNUM_END,
			// Token: 0x040020BE RID: 8382
			[Token(Token = "0x40020BE")]
			CustomRoomSetting_INITCOIN_START,
			// Token: 0x040020BF RID: 8383
			[Token(Token = "0x40020BF")]
			CustomRoomSetting_INITCOIN_END,
			// Token: 0x040020C0 RID: 8384
			[Token(Token = "0x40020C0")]
			CustomRoomSetting_NOPOWERGUN
		}

		// Token: 0x0200067F RID: 1663
		[Token(Token = "0x200067F")]
		[ProtoContract]
		public enum CustomRoomSetting2
		{
			// Token: 0x040020C2 RID: 8386
			[Token(Token = "0x40020C2")]
			CustomRoomSetting2_NOUAV,
			// Token: 0x040020C3 RID: 8387
			[Token(Token = "0x40020C3")]
			CustomRoomSetting2_NOBOMB
		}

		// Token: 0x02000680 RID: 1664
		[Token(Token = "0x2000680")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x040020C5 RID: 8389
			[Token(Token = "0x40020C5")]
			Type_NONE,
			// Token: 0x040020C6 RID: 8390
			[Token(Token = "0x40020C6")]
			Type_CASUAL,
			// Token: 0x040020C7 RID: 8391
			[Token(Token = "0x40020C7")]
			Type_LEAGUE_NORMAL,
			// Token: 0x040020C8 RID: 8392
			[Token(Token = "0x40020C8")]
			Type_LEAGUE_BATCH = 6,
			// Token: 0x040020C9 RID: 8393
			[Token(Token = "0x40020C9")]
			Type_WEREWOLVES
		}

		// Token: 0x02000681 RID: 1665
		[Token(Token = "0x2000681")]
		[ProtoContract]
		public enum CardType
		{
			// Token: 0x040020CB RID: 8395
			[Token(Token = "0x40020CB")]
			CardType_NONE,
			// Token: 0x040020CC RID: 8396
			[Token(Token = "0x40020CC")]
			CardType_NORMAL,
			// Token: 0x040020CD RID: 8397
			[Token(Token = "0x40020CD")]
			CardType_ADVANCED,
			// Token: 0x040020CE RID: 8398
			[Token(Token = "0x40020CE")]
			CardType_WEREWOLVES
		}
	}
}
