using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001596 RID: 5526
	[Token(Token = "0x2001596")]
	public class FriendInfo : IComparable<FriendInfo>, IEqualityComparer<FriendInfo>
	{
		// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x1B9BA4C", Offset = "0x1B9BA4C", VA = "0x7BBC39BA4C")]
		public static implicit operator FriendInfo(FriendAccountInfo accountInfo)
		{
			return null;
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0x1B9BC1C", Offset = "0x1B9BC1C", VA = "0x7BBC39BC1C")]
		public static implicit operator FriendInfo(ClanMember memberInfo)
		{
			return null;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E7")]
		[Address(RVA = "0x1B9BD78", Offset = "0x1B9BD78", VA = "0x7BBC39BD78")]
		public static implicit operator FriendInfo(GroupMemberInfo memberInfo)
		{
			return null;
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x1B9BEE4", Offset = "0x1B9BEE4", VA = "0x7BBC39BEE4")]
		public static implicit operator FriendInfo(TeammateStats memberInfo)
		{
			return null;
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x0001BF18 File Offset: 0x0001A118
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0x1B9C0A4", Offset = "0x1B9C0A4", VA = "0x7BBC39C0A4", Slot = "4")]
		public int CompareTo(FriendInfo other)
		{
			return 0;
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x0001BF30 File Offset: 0x0001A130
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0x1B9C180", Offset = "0x1B9C180", VA = "0x7BBC39C180", Slot = "5")]
		public bool Equals(FriendInfo x, FriendInfo y)
		{
			return default(bool);
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x0001BF48 File Offset: 0x0001A148
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0x1B9C1C8", Offset = "0x1B9C1C8", VA = "0x7BBC39C1C8", Slot = "6")]
		public int GetHashCode(FriendInfo obj)
		{
			return 0;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0x1B9BC14", Offset = "0x1B9BC14", VA = "0x7BBC39BC14")]
		public FriendInfo()
		{
		}

		// Token: 0x040080D6 RID: 32982
		[Token(Token = "0x40080D6")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_AccountId;

		// Token: 0x040080D7 RID: 32983
		[Token(Token = "0x40080D7")]
		[FieldOffset(Offset = "0x18")]
		public uint m_Level;

		// Token: 0x040080D8 RID: 32984
		[Token(Token = "0x40080D8")]
		[FieldOffset(Offset = "0x20")]
		public string m_Name;

		// Token: 0x040080D9 RID: 32985
		[Token(Token = "0x40080D9")]
		[FieldOffset(Offset = "0x28")]
		public string m_PortraitUrl;

		// Token: 0x040080DA RID: 32986
		[Token(Token = "0x40080DA")]
		[FieldOffset(Offset = "0x30")]
		public uint m_Banner;

		// Token: 0x040080DB RID: 32987
		[Token(Token = "0x40080DB")]
		[FieldOffset(Offset = "0x34")]
		public uint m_HeadPic;

		// Token: 0x040080DC RID: 32988
		[Token(Token = "0x40080DC")]
		[FieldOffset(Offset = "0x38")]
		public proto.EPresence.AccountPresence m_OnlineStatus;

		// Token: 0x040080DD RID: 32989
		[Token(Token = "0x40080DD")]
		[FieldOffset(Offset = "0x3C")]
		public bool m_IsSelected;

		// Token: 0x040080DE RID: 32990
		[Token(Token = "0x40080DE")]
		[FieldOffset(Offset = "0x3D")]
		public bool m_IsMeetCondition;

		// Token: 0x040080DF RID: 32991
		[Token(Token = "0x40080DF")]
		[FieldOffset(Offset = "0x3E")]
		public bool m_IsFavor;

		// Token: 0x040080E0 RID: 32992
		[Token(Token = "0x40080E0")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton m_UIToggleBtn;

		// Token: 0x040080E1 RID: 32993
		[Token(Token = "0x40080E1")]
		[FieldOffset(Offset = "0x48")]
		public string m_Reason;

		// Token: 0x040080E2 RID: 32994
		[Token(Token = "0x40080E2")]
		[FieldOffset(Offset = "0x50")]
		public EGiftStore_BuddyType m_BuddyType;

		// Token: 0x040080E3 RID: 32995
		[Token(Token = "0x40080E3")]
		[FieldOffset(Offset = "0x58")]
		public string m_Region;
	}
}
