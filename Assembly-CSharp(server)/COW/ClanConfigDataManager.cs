using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CBB RID: 7355
	[Token(Token = "0x2001CBB")]
	internal class ClanConfigDataManager : SingletonModule<ClanConfigDataManager>
	{
		// Token: 0x0600A06B RID: 41067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A06B")]
		[Address(RVA = "0x14F6914", Offset = "0x14F6914", VA = "0x7BBBCF6914", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A06C")]
		[Address(RVA = "0x14F6918", Offset = "0x14F6918", VA = "0x7BBBCF6918", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x00029F58 File Offset: 0x00028158
		[Token(Token = "0x600A06D")]
		[Address(RVA = "0x14F699C", Offset = "0x14F699C", VA = "0x7BBBCF699C")]
		public bool IsOpenArea()
		{
			return default(bool);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x00029F70 File Offset: 0x00028170
		[Token(Token = "0x600A06E")]
		[Address(RVA = "0x14F6A44", Offset = "0x14F6A44", VA = "0x7BBBCF6A44")]
		public int GetFilterMenuItemCount()
		{
			return 0;
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A06F")]
		[Address(RVA = "0x14F6B18", Offset = "0x14F6B18", VA = "0x7BBBCF6B18")]
		public string StringArrayToLabel(List<string> strs)
		{
			return null;
		}

		// Token: 0x0600A070 RID: 41072 RVA: 0x00029F88 File Offset: 0x00028188
		[Token(Token = "0x600A070")]
		[Address(RVA = "0x14F6D00", Offset = "0x14F6D00", VA = "0x7BBBCF6D00")]
		public EClan.ClanMainType GetClanTypeFromString(string content)
		{
			return EClan.ClanMainType.ClanMainType_NONE;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A071")]
		[Address(RVA = "0x14F6DB4", Offset = "0x14F6DB4", VA = "0x7BBBCF6DB4")]
		public string GetTagStringLabelFromID(uint tagId)
		{
			return null;
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A072")]
		[Address(RVA = "0x14F6E70", Offset = "0x14F6E70", VA = "0x7BBBCF6E70")]
		public string GetTagStringKeyFromID(uint tagId)
		{
			return null;
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x00029FA0 File Offset: 0x000281A0
		[Token(Token = "0x600A073")]
		[Address(RVA = "0x14F6F38", Offset = "0x14F6F38", VA = "0x7BBBCF6F38")]
		public uint GetTagIDFromTagString(string tag)
		{
			return 0U;
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A074")]
		[Address(RVA = "0x14F708C", Offset = "0x14F708C", VA = "0x7BBBCF708C")]
		public List<MultiPopMenuListData> GetTags()
		{
			return null;
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A075")]
		[Address(RVA = "0x14F7270", Offset = "0x14F7270", VA = "0x7BBBCF7270")]
		public List<MultiPopMenuListData> GetFilterList()
		{
			return null;
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A076")]
		[Address(RVA = "0x14F7AF4", Offset = "0x14F7AF4", VA = "0x7BBBCF7AF4")]
		public List<MultiPopMenuListData> GetRankCondList()
		{
			return null;
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A077")]
		[Address(RVA = "0x14F7D18", Offset = "0x14F7D18", VA = "0x7BBBCF7D18")]
		public string GetRankCondStringFromID(uint rank)
		{
			return null;
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A078")]
		[Address(RVA = "0x14F7E54", Offset = "0x14F7E54", VA = "0x7BBBCF7E54")]
		public List<MultiPopMenuListData> GetLevelCondList()
		{
			return null;
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A079")]
		[Address(RVA = "0x14F8040", Offset = "0x14F8040", VA = "0x7BBBCF8040")]
		public string GetLevelCondStringFromID(uint level)
		{
			return null;
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A07A")]
		[Address(RVA = "0x14F764C", Offset = "0x14F764C", VA = "0x7BBBCF764C")]
		public List<MultiPopMenuListData> GetAreaList()
		{
			return null;
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x00029FB8 File Offset: 0x000281B8
		[Token(Token = "0x600A07B")]
		[Address(RVA = "0x14F812C", Offset = "0x14F812C", VA = "0x7BBBCF812C")]
		public uint GetAreaIDFromString(string country, string area)
		{
			return 0U;
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A07C")]
		[Address(RVA = "0x14F82A8", Offset = "0x14F82A8", VA = "0x7BBBCF82A8")]
		public string[] GetAreaStringArrayFromID(uint areaId)
		{
			return null;
		}

		// Token: 0x0600A07D RID: 41085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A07D")]
		[Address(RVA = "0x14F8454", Offset = "0x14F8454", VA = "0x7BBBCF8454")]
		public string GetAreaStringFromID(uint areaId)
		{
			return null;
		}

		// Token: 0x0600A07E RID: 41086 RVA: 0x00029FD0 File Offset: 0x000281D0
		[Token(Token = "0x600A07E")]
		[Address(RVA = "0x14F86EC", Offset = "0x14F86EC", VA = "0x7BBBCF86EC")]
		public int GetClanMaxPendingApplications()
		{
			return 0;
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A07F")]
		[Address(RVA = "0x14F878C", Offset = "0x14F878C", VA = "0x7BBBCF878C")]
		public ClanConfigDataManager()
		{
		}

		// Token: 0x0400A73F RID: 42815
		[Token(Token = "0x400A73F")]
		[FieldOffset(Offset = "0x18")]
		private string[] m_FilterPool;

		// Token: 0x0400A740 RID: 42816
		[Token(Token = "0x400A740")]
		[FieldOffset(Offset = "0x20")]
		private List<MultiPopMenuListData> m_RankCondDatas;

		// Token: 0x0400A741 RID: 42817
		[Token(Token = "0x400A741")]
		[FieldOffset(Offset = "0x28")]
		private List<MultiPopMenuListData> m_LevelCondDatas;

		// Token: 0x02001CBC RID: 7356
		[Token(Token = "0x2001CBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB974", Offset = "0x10FB974")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x0600A080 RID: 41088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A080")]
			[Address(RVA = "0x14F811C", Offset = "0x14F811C", VA = "0x7BBBCF811C")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x0600A081 RID: 41089 RVA: 0x00029FE8 File Offset: 0x000281E8
			[Token(Token = "0x600A081")]
			[Address(RVA = "0x14F890C", Offset = "0x14F890C", VA = "0x7BBBCF890C")]
			internal bool <GetAreaList>b__0(MultiPopMenuListData temp)
			{
				return default(bool);
			}

			// Token: 0x0400A742 RID: 42818
			[Token(Token = "0x400A742")]
			[FieldOffset(Offset = "0x10")]
			public ClanAreaData data;
		}

		// Token: 0x02001CBD RID: 7357
		[Token(Token = "0x2001CBD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB984", Offset = "0x10FB984")]
		private sealed class <>c__DisplayClass18_1
		{
			// Token: 0x0600A082 RID: 41090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A082")]
			[Address(RVA = "0x14F8124", Offset = "0x14F8124", VA = "0x7BBBCF8124")]
			public <>c__DisplayClass18_1()
			{
			}

			// Token: 0x0600A083 RID: 41091 RVA: 0x0002A000 File Offset: 0x00028200
			[Token(Token = "0x600A083")]
			[Address(RVA = "0x14F8958", Offset = "0x14F8958", VA = "0x7BBBCF8958")]
			internal bool <GetAreaList>b__1(MultiPopMenuListData temp)
			{
				return default(bool);
			}

			// Token: 0x0400A743 RID: 42819
			[Token(Token = "0x400A743")]
			[FieldOffset(Offset = "0x10")]
			public ClanAreaData data;
		}
	}
}
