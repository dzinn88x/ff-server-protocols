using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CA6 RID: 7334
	[Token(Token = "0x2001CA6")]
	public class AvatarProfile : IComparable<AvatarProfile>
	{
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600A01B RID: 40987 RVA: 0x00029E80 File Offset: 0x00028080
		[Token(Token = "0x17000A8A")]
		public uint CurDebrisCount
		{
			[Token(Token = "0x600A01B")]
			[Address(RVA = "0x1562204", Offset = "0x1562204", VA = "0x7BBBD62204")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600A01C RID: 40988 RVA: 0x00029E98 File Offset: 0x00028098
		// (set) Token: 0x0600A01D RID: 40989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A8B")]
		public int UnLockedSkillCount
		{
			[Token(Token = "0x600A01C")]
			[Address(RVA = "0x156246C", Offset = "0x156246C", VA = "0x7BBBD6246C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A01D")]
			[Address(RVA = "0x1562474", Offset = "0x1562474", VA = "0x7BBBD62474")]
			set
			{
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8C")]
		public Dictionary<int, uint> EquippedSkills
		{
			[Token(Token = "0x600A01E")]
			[Address(RVA = "0x156247C", Offset = "0x156247C", VA = "0x7BBBD6247C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600A01F RID: 40991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8D")]
		public CSSharedAvatarData BasicInfo
		{
			[Token(Token = "0x600A01F")]
			[Address(RVA = "0x1562484", Offset = "0x1562484", VA = "0x7BBBD62484")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8E")]
		public AvatarProfileDataOverrided CurProfileData
		{
			[Token(Token = "0x600A020")]
			[Address(RVA = "0x15623B0", Offset = "0x15623B0", VA = "0x7BBBD623B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x0600A021 RID: 40993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A8F")]
		public AvatarProfileDataOverrided NextProfileData
		{
			[Token(Token = "0x600A021")]
			[Address(RVA = "0x15622EC", Offset = "0x15622EC", VA = "0x7BBBD622EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x0600A022 RID: 40994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A90")]
		public List<AvatarProfileDataOverrided> AvatarConfigDataList
		{
			[Token(Token = "0x600A022")]
			[Address(RVA = "0x1562528", Offset = "0x1562528", VA = "0x7BBBD62528")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A023 RID: 40995 RVA: 0x00029EB0 File Offset: 0x000280B0
		[Token(Token = "0x600A023")]
		[Address(RVA = "0x156277C", Offset = "0x156277C", VA = "0x7BBBD6277C")]
		public uint GetSkillBySlot(int slotID)
		{
			return 0U;
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A024")]
		[Address(RVA = "0x15628F0", Offset = "0x15628F0", VA = "0x7BBBD628F0")]
		public void SetSkillBySlot(int slotID, uint skillID)
		{
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A025")]
		[Address(RVA = "0x1562988", Offset = "0x1562988", VA = "0x7BBBD62988")]
		public void ClearEquippedSkills()
		{
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A91")]
		public List<AvatarSuit> SuitList
		{
			[Token(Token = "0x600A026")]
			[Address(RVA = "0x15629E8", Offset = "0x15629E8", VA = "0x7BBBD629E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A027 RID: 40999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A027")]
		[Address(RVA = "0x1562C3C", Offset = "0x1562C3C", VA = "0x7BBBD62C3C")]
		public void UpdateSuitOwnStatus(uint suitID, bool hasOwnComplete)
		{
		}

		// Token: 0x0600A028 RID: 41000 RVA: 0x00029EC8 File Offset: 0x000280C8
		[Token(Token = "0x600A028")]
		[Address(RVA = "0x1562D54", Offset = "0x1562D54", VA = "0x7BBBD62D54", Slot = "4")]
		public int CompareTo(AvatarProfile other)
		{
			return 0;
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A029")]
		[Address(RVA = "0x1562DF8", Offset = "0x1562DF8", VA = "0x7BBBD62DF8")]
		public AvatarProfile()
		{
		}

		// Token: 0x0400A6EA RID: 42730
		[Token(Token = "0x400A6EA")]
		[FieldOffset(Offset = "0x10")]
		public uint AvatarID;

		// Token: 0x0400A6EB RID: 42731
		[Token(Token = "0x400A6EB")]
		[FieldOffset(Offset = "0x14")]
		public int SortID;

		// Token: 0x0400A6EC RID: 42732
		[Token(Token = "0x400A6EC")]
		[FieldOffset(Offset = "0x18")]
		public bool IsSelected;

		// Token: 0x0400A6ED RID: 42733
		[Token(Token = "0x400A6ED")]
		[FieldOffset(Offset = "0x19")]
		public bool hasOwnAvatar;

		// Token: 0x0400A6EE RID: 42734
		[Token(Token = "0x400A6EE")]
		[FieldOffset(Offset = "0x1A")]
		public bool hasOwnAvatarItem;

		// Token: 0x0400A6EF RID: 42735
		[Token(Token = "0x400A6EF")]
		[FieldOffset(Offset = "0x1C")]
		public int CurProfileLevel;

		// Token: 0x0400A6F0 RID: 42736
		[Token(Token = "0x400A6F0")]
		[FieldOffset(Offset = "0x20")]
		public AvatarSkill CurSkill;

		// Token: 0x0400A6F1 RID: 42737
		[Token(Token = "0x400A6F1")]
		[FieldOffset(Offset = "0x28")]
		private int unLockedSkillCount;

		// Token: 0x0400A6F2 RID: 42738
		[Token(Token = "0x400A6F2")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsAwakenSelect;

		// Token: 0x0400A6F3 RID: 42739
		[Token(Token = "0x400A6F3")]
		[FieldOffset(Offset = "0x30")]
		public uint ExpireTime;

		// Token: 0x0400A6F4 RID: 42740
		[Token(Token = "0x400A6F4")]
		[FieldOffset(Offset = "0x38")]
		private List<AvatarProfileDataOverrided> m_AvatarConfigDataList;

		// Token: 0x0400A6F5 RID: 42741
		[Token(Token = "0x400A6F5")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<int, uint> m_EquippedSkills;

		// Token: 0x0400A6F6 RID: 42742
		[Token(Token = "0x400A6F6")]
		[FieldOffset(Offset = "0x48")]
		private List<AvatarSuit> m_SuitList;

		// Token: 0x02001CA7 RID: 7335
		[Token(Token = "0x2001CA7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB934", Offset = "0x10FB934")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A02B RID: 41003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A02B")]
			[Address(RVA = "0x1562ED8", Offset = "0x1562ED8", VA = "0x7BBBD62ED8")]
			public <>c()
			{
			}

			// Token: 0x0600A02C RID: 41004 RVA: 0x00029EE0 File Offset: 0x000280E0
			[Token(Token = "0x600A02C")]
			[Address(RVA = "0x1562EE0", Offset = "0x1562EE0", VA = "0x7BBBD62EE0")]
			internal int <get_AvatarConfigDataList>b__27_0(AvatarProfileDataOverrided a, AvatarProfileDataOverrided b)
			{
				return 0;
			}

			// Token: 0x0400A6F7 RID: 42743
			[Token(Token = "0x400A6F7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AvatarProfile.<>c <>9;

			// Token: 0x0400A6F8 RID: 42744
			[Token(Token = "0x400A6F8")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AvatarProfileDataOverrided> <>9__27_0;
		}
	}
}
