using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D3 RID: 4307
	[Token(Token = "0x20010D3")]
	public class WeaponEffectConfigData : CSVBaseData, IGetId
	{
		// Token: 0x0600431F RID: 17183 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x600431F")]
		[Address(RVA = "0x179BD60", Offset = "0x179BD60", VA = "0x7BBBF9BD60", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004320")]
		[Address(RVA = "0x179BD68", Offset = "0x179BD68", VA = "0x7BBBF9BD68", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004321")]
		[Address(RVA = "0x179BD74", Offset = "0x179BD74", VA = "0x7BBBF9BD74", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004322")]
		[Address(RVA = "0x179C0B4", Offset = "0x179C0B4", VA = "0x7BBBF9C0B4")]
		public WeaponEffectConfigData()
		{
		}

		// Token: 0x040052A6 RID: 21158
		[Token(Token = "0x40052A6")]
		[FieldOffset(Offset = "0x10")]
		public uint quality;

		// Token: 0x040052A7 RID: 21159
		[Token(Token = "0x40052A7")]
		[FieldOffset(Offset = "0x14")]
		public uint effectMyHand;

		// Token: 0x040052A8 RID: 21160
		[Token(Token = "0x40052A8")]
		[FieldOffset(Offset = "0x18")]
		public uint effectMyBack;

		// Token: 0x040052A9 RID: 21161
		[Token(Token = "0x40052A9")]
		[FieldOffset(Offset = "0x1C")]
		public uint effectTeammateHand;

		// Token: 0x040052AA RID: 21162
		[Token(Token = "0x40052AA")]
		[FieldOffset(Offset = "0x20")]
		public uint effectTeammateBack;

		// Token: 0x040052AB RID: 21163
		[Token(Token = "0x40052AB")]
		[FieldOffset(Offset = "0x24")]
		public uint effectEnemyHand;

		// Token: 0x040052AC RID: 21164
		[Token(Token = "0x40052AC")]
		[FieldOffset(Offset = "0x28")]
		public uint effectEnemyBack;

		// Token: 0x040052AD RID: 21165
		[Token(Token = "0x40052AD")]
		[FieldOffset(Offset = "0x2C")]
		public uint effectMyFire;

		// Token: 0x040052AE RID: 21166
		[Token(Token = "0x40052AE")]
		[FieldOffset(Offset = "0x30")]
		public uint effectTeammateFire;

		// Token: 0x040052AF RID: 21167
		[Token(Token = "0x40052AF")]
		[FieldOffset(Offset = "0x34")]
		public uint effectEnemyFire;

		// Token: 0x040052B0 RID: 21168
		[Token(Token = "0x40052B0")]
		[FieldOffset(Offset = "0x38")]
		public uint effectMyHit;

		// Token: 0x040052B1 RID: 21169
		[Token(Token = "0x40052B1")]
		[FieldOffset(Offset = "0x3C")]
		public uint effectTeammateHit;

		// Token: 0x040052B2 RID: 21170
		[Token(Token = "0x40052B2")]
		[FieldOffset(Offset = "0x40")]
		public uint effectEnemyHit;

		// Token: 0x040052B3 RID: 21171
		[Token(Token = "0x40052B3")]
		[FieldOffset(Offset = "0x44")]
		public uint effectMyKill;

		// Token: 0x040052B4 RID: 21172
		[Token(Token = "0x40052B4")]
		[FieldOffset(Offset = "0x48")]
		public uint effectTeammateKill;

		// Token: 0x040052B5 RID: 21173
		[Token(Token = "0x40052B5")]
		[FieldOffset(Offset = "0x4C")]
		public uint effectEnemyKill;

		// Token: 0x040052B6 RID: 21174
		[Token(Token = "0x40052B6")]
		[FieldOffset(Offset = "0x50")]
		public uint effectMyAnnounce;

		// Token: 0x040052B7 RID: 21175
		[Token(Token = "0x40052B7")]
		[FieldOffset(Offset = "0x54")]
		public uint effectTeammateAnnounce;

		// Token: 0x040052B8 RID: 21176
		[Token(Token = "0x40052B8")]
		[FieldOffset(Offset = "0x58")]
		public uint effectEnemyAnnounce;

		// Token: 0x040052B9 RID: 21177
		[Token(Token = "0x40052B9")]
		[FieldOffset(Offset = "0x5C")]
		public uint effectMyGunTrace;
	}
}
