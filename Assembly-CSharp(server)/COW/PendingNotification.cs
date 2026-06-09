using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C4F RID: 7247
	[Token(Token = "0x2001C4F")]
	public class PendingNotification
	{
		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A63")]
		public string KillerName
		{
			[Token(Token = "0x6009DA1")]
			[Address(RVA = "0x204BC58", Offset = "0x204BC58", VA = "0x7BBC84BC58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009DA0")]
			[Address(RVA = "0x204BC50", Offset = "0x204BC50", VA = "0x7BBC84BC50")]
			set
			{
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DA2 RID: 40354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A64")]
		public string BeKilledName
		{
			[Token(Token = "0x6009DA3")]
			[Address(RVA = "0x204BD1C", Offset = "0x204BD1C", VA = "0x7BBC84BD1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009DA2")]
			[Address(RVA = "0x204BD14", Offset = "0x204BD14", VA = "0x7BBC84BD14")]
			set
			{
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A65")]
		public string KnockDownPlayerName
		{
			[Token(Token = "0x6009DA5")]
			[Address(RVA = "0x204BDE0", Offset = "0x204BDE0", VA = "0x7BBC84BDE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009DA4")]
			[Address(RVA = "0x204BDD8", Offset = "0x204BDD8", VA = "0x7BBC84BDD8")]
			set
			{
			}
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DA6")]
		[Address(RVA = "0x204BE9C", Offset = "0x204BE9C", VA = "0x7BBC84BE9C")]
		public void Reset()
		{
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DA7")]
		[Address(RVA = "0x204BF88", Offset = "0x204BF88", VA = "0x7BBC84BF88")]
		public PendingNotification()
		{
		}

		// Token: 0x0400A3D4 RID: 41940
		[Token(Token = "0x400A3D4")]
		[FieldOffset(Offset = "0x10")]
		public {QAb\u0082~u KillerId;

		// Token: 0x0400A3D5 RID: 41941
		[Token(Token = "0x400A3D5")]
		[FieldOffset(Offset = "0x28")]
		public string m_KillerName;

		// Token: 0x0400A3D6 RID: 41942
		[Token(Token = "0x400A3D6")]
		[FieldOffset(Offset = "0x30")]
		public string m_BeKilledName;

		// Token: 0x0400A3D7 RID: 41943
		[Token(Token = "0x400A3D7")]
		[FieldOffset(Offset = "0x38")]
		public string WeaponName;

		// Token: 0x0400A3D8 RID: 41944
		[Token(Token = "0x400A3D8")]
		[FieldOffset(Offset = "0x40")]
		public string KillerNameColor;

		// Token: 0x0400A3D9 RID: 41945
		[Token(Token = "0x400A3D9")]
		[FieldOffset(Offset = "0x48")]
		public string BeKilledNameColor;

		// Token: 0x0400A3DA RID: 41946
		[Token(Token = "0x400A3DA")]
		[FieldOffset(Offset = "0x50")]
		public bool ShowKillBonus;

		// Token: 0x0400A3DB RID: 41947
		[Token(Token = "0x400A3DB")]
		[FieldOffset(Offset = "0x58")]
		public string BattleInfo;

		// Token: 0x0400A3DC RID: 41948
		[Token(Token = "0x400A3DC")]
		[FieldOffset(Offset = "0x60")]
		public EPendingNotificationType InfoType;

		// Token: 0x0400A3DD RID: 41949
		[Token(Token = "0x400A3DD")]
		[FieldOffset(Offset = "0x68")]
		public string m_KnockDownPlayerName;

		// Token: 0x0400A3DE RID: 41950
		[Token(Token = "0x400A3DE")]
		[FieldOffset(Offset = "0x70")]
		public string KnockDownWeaponName;

		// Token: 0x0400A3DF RID: 41951
		[Token(Token = "0x400A3DF")]
		[FieldOffset(Offset = "0x78")]
		public uint SkinItemId;

		// Token: 0x0400A3E0 RID: 41952
		[Token(Token = "0x400A3E0")]
		[FieldOffset(Offset = "0x7C")]
		public uint WeaponID;

		// Token: 0x0400A3E1 RID: 41953
		[Token(Token = "0x400A3E1")]
		[FieldOffset(Offset = "0x80")]
		public float DefaultVisibleTime;

		// Token: 0x0400A3E2 RID: 41954
		[Token(Token = "0x400A3E2")]
		[FieldOffset(Offset = "0x84")]
		public uint KillerRole;

		// Token: 0x0400A3E3 RID: 41955
		[Token(Token = "0x400A3E3")]
		[FieldOffset(Offset = "0x88")]
		public uint BeKilledRole;

		// Token: 0x0400A3E4 RID: 41956
		[Token(Token = "0x400A3E4")]
		[FieldOffset(Offset = "0x8C")]
		public uint KnockDownRole;
	}
}
