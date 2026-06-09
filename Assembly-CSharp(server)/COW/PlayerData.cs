using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FF0 RID: 8176
	[Token(Token = "0x2001FF0")]
	internal class PlayerData
	{
		// Token: 0x0600B5F8 RID: 46584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5F8")]
		[Address(RVA = "0x1EFEB38", Offset = "0x1EFEB38", VA = "0x7BBC6FEB38")]
		public static implicit operator BaseProfileInfo(PlayerData playerDataInfo)
		{
			return null;
		}

		// Token: 0x0600B5F9 RID: 46585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5F9")]
		[Address(RVA = "0x1EFEC28", Offset = "0x1EFEC28", VA = "0x7BBC6FEC28")]
		public PlayerData Clone()
		{
			return null;
		}

		// Token: 0x0600B5FA RID: 46586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5FA")]
		[Address(RVA = "0x1EFED40", Offset = "0x1EFED40", VA = "0x7BBC6FED40")]
		public PlayerData()
		{
		}

		// Token: 0x0400B7F7 RID: 47095
		[Token(Token = "0x400B7F7")]
		[FieldOffset(Offset = "0x10")]
		public {QAb\u0082~u id;

		// Token: 0x0400B7F8 RID: 47096
		[Token(Token = "0x400B7F8")]
		[FieldOffset(Offset = "0x28")]
		public ulong userId;

		// Token: 0x0400B7F9 RID: 47097
		[Token(Token = "0x400B7F9")]
		[FieldOffset(Offset = "0x30")]
		public byte gsTeamId;

		// Token: 0x0400B7FA RID: 47098
		[Token(Token = "0x400B7FA")]
		[FieldOffset(Offset = "0x31")]
		public byte scTeamId;

		// Token: 0x0400B7FB RID: 47099
		[Token(Token = "0x400B7FB")]
		[FieldOffset(Offset = "0x32")]
		public byte scMemberId;

		// Token: 0x0400B7FC RID: 47100
		[Token(Token = "0x400B7FC")]
		[FieldOffset(Offset = "0x38")]
		public string nickname;

		// Token: 0x0400B7FD RID: 47101
		[Token(Token = "0x400B7FD")]
		[FieldOffset(Offset = "0x40")]
		public string teamname;

		// Token: 0x0400B7FE RID: 47102
		[Token(Token = "0x400B7FE")]
		[FieldOffset(Offset = "0x48")]
		public string teamnameabbr;

		// Token: 0x0400B7FF RID: 47103
		[Token(Token = "0x400B7FF")]
		[FieldOffset(Offset = "0x50")]
		public uint headicon;

		// Token: 0x0400B800 RID: 47104
		[Token(Token = "0x400B800")]
		[FieldOffset(Offset = "0x54")]
		public uint teamicon;

		// Token: 0x0400B801 RID: 47105
		[Token(Token = "0x400B801")]
		[FieldOffset(Offset = "0x58")]
		public uint killCount;

		// Token: 0x0400B802 RID: 47106
		[Token(Token = "0x400B802")]
		[FieldOffset(Offset = "0x5C")]
		public uint damage;

		// Token: 0x0400B803 RID: 47107
		[Token(Token = "0x400B803")]
		[FieldOffset(Offset = "0x60")]
		public bool isDead;

		// Token: 0x0400B804 RID: 47108
		[Token(Token = "0x400B804")]
		[FieldOffset(Offset = "0x68")]
		public string area;

		// Token: 0x0400B805 RID: 47109
		[Token(Token = "0x400B805")]
		[FieldOffset(Offset = "0x70")]
		public uint deadCount;

		// Token: 0x0400B806 RID: 47110
		[Token(Token = "0x400B806")]
		[FieldOffset(Offset = "0x74")]
		public uint assistCount;

		// Token: 0x0400B807 RID: 47111
		[Token(Token = "0x400B807")]
		[FieldOffset(Offset = "0x78")]
		public uint avatarID;

		// Token: 0x0400B808 RID: 47112
		[Token(Token = "0x400B808")]
		[FieldOffset(Offset = "0x80")]
		public List<uint> clothes;

		// Token: 0x0400B809 RID: 47113
		[Token(Token = "0x400B809")]
		[FieldOffset(Offset = "0x88")]
		public uint skinColor;

		// Token: 0x0400B80A RID: 47114
		[Token(Token = "0x400B80A")]
		[FieldOffset(Offset = "0x90")]
		public string ClanName;

		// Token: 0x0400B80B RID: 47115
		[Token(Token = "0x400B80B")]
		[FieldOffset(Offset = "0x98")]
		public uint showWeaponId;

		// Token: 0x0400B80C RID: 47116
		[Token(Token = "0x400B80C")]
		[FieldOffset(Offset = "0x9C")]
		public uint BannerId;

		// Token: 0x0400B80D RID: 47117
		[Token(Token = "0x400B80D")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 lastPosition;

		// Token: 0x0400B80E RID: 47118
		[Token(Token = "0x400B80E")]
		[FieldOffset(Offset = "0xAC")]
		public Vector3 lastForward;

		// Token: 0x0400B80F RID: 47119
		[Token(Token = "0x400B80F")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<HesZZW, int> itemDic;

		// Token: 0x0400B810 RID: 47120
		[Token(Token = "0x400B810")]
		[FieldOffset(Offset = "0xC0")]
		public Player player;

		// Token: 0x0400B811 RID: 47121
		[Token(Token = "0x400B811")]
		[FieldOffset(Offset = "0xC8")]
		public float headScale;

		// Token: 0x0400B812 RID: 47122
		[Token(Token = "0x400B812")]
		[FieldOffset(Offset = "0xCC")]
		public uint headAvatarID;

		// Token: 0x0400B813 RID: 47123
		[Token(Token = "0x400B813")]
		[FieldOffset(Offset = "0xD0")]
		public int score;

		// Token: 0x0400B814 RID: 47124
		[Token(Token = "0x400B814")]
		[FieldOffset(Offset = "0xD4")]
		public int factionId;

		// Token: 0x0400B815 RID: 47125
		[Token(Token = "0x400B815")]
		[FieldOffset(Offset = "0xD8")]
		public uint likeCount;

		// Token: 0x0400B816 RID: 47126
		[Token(Token = "0x400B816")]
		[FieldOffset(Offset = "0xDC")]
		public uint rank;

		// Token: 0x0400B817 RID: 47127
		[Token(Token = "0x400B817")]
		[FieldOffset(Offset = "0xE0")]
		public uint role;
	}
}
