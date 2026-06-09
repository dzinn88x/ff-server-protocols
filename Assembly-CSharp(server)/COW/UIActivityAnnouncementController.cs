using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013DE RID: 5086
	[Token(Token = "0x20013DE")]
	public class UIActivityAnnouncementController : UIActivityBaseController
	{
		// Token: 0x06005371 RID: 21361 RVA: 0x00018EE8 File Offset: 0x000170E8
		[Token(Token = "0x6005371")]
		[Address(RVA = "0x1A441F8", Offset = "0x1A441F8", VA = "0x7BBC2441F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x1A44248", Offset = "0x1A44248", VA = "0x7BBC244248", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x1A44954", Offset = "0x1A44954", VA = "0x7BBC244954", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005374")]
		[Address(RVA = "0x1A4495C", Offset = "0x1A4495C", VA = "0x7BBC24495C", Slot = "29")]
		public override void SelectItem(uint id)
		{
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005375")]
		[Address(RVA = "0x1A44A70", Offset = "0x1A44A70", VA = "0x7BBC244A70")]
		public void ActivityGroupSelected(AnnoucementInfo info)
		{
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005376")]
		[Address(RVA = "0x1A44CF4", Offset = "0x1A44CF4", VA = "0x7BBC244CF4", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005377")]
		[Address(RVA = "0x1A45014", Offset = "0x1A45014", VA = "0x7BBC245014")]
		private void OnTabItemSelect(StandardTabItemViewData viewData)
		{
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x1A45178", Offset = "0x1A45178", VA = "0x7BBC245178")]
		private void OnOperate()
		{
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x1A453A4", Offset = "0x1A453A4", VA = "0x7BBC2453A4")]
		private void OpenCommunityWebsite(bool facebook = false, bool offical = false, bool ins = false)
		{
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600537A")]
		[Address(RVA = "0x1A44638", Offset = "0x1A44638", VA = "0x7BBC244638")]
		private CommunityWebsiteData GetCommunityWebsiteData()
		{
			return null;
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537B")]
		[Address(RVA = "0x1A45590", Offset = "0x1A45590", VA = "0x7BBC245590")]
		public UIActivityAnnouncementController()
		{
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537C")]
		[Address(RVA = "0x1A45608", Offset = "0x1A45608", VA = "0x7BBC245608")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E4F0", Offset = "0x113E4F0")]
		private void <OnUIInit>b__8_0()
		{
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537D")]
		[Address(RVA = "0x1A45618", Offset = "0x1A45618", VA = "0x7BBC245618")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E500", Offset = "0x113E500")]
		private void <OnUIInit>b__8_1()
		{
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537E")]
		[Address(RVA = "0x1A45628", Offset = "0x1A45628", VA = "0x7BBC245628")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E510", Offset = "0x113E510")]
		private void <OnUIInit>b__8_2()
		{
		}

		// Token: 0x0400792E RID: 31022
		[Token(Token = "0x400792E")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityAnnouncementView m_View;

		// Token: 0x0400792F RID: 31023
		[Token(Token = "0x400792F")]
		[FieldOffset(Offset = "0x60")]
		private List<AnnoucementInfo> m_GroupDescs;

		// Token: 0x04007930 RID: 31024
		[Token(Token = "0x4007930")]
		[FieldOffset(Offset = "0x68")]
		private AnnoucementInfo m_SelectInfo;

		// Token: 0x04007931 RID: 31025
		[Token(Token = "0x4007931")]
		[FieldOffset(Offset = "0x70")]
		private CommunityWebsiteData m_websiteData;

		// Token: 0x04007932 RID: 31026
		[Token(Token = "0x4007932")]
		[FieldOffset(Offset = "0x78")]
		private UIModelAnnouncement m_ModelAnnouncement;

		// Token: 0x04007933 RID: 31027
		[Token(Token = "0x4007933")]
		[FieldOffset(Offset = "0x80")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x04007934 RID: 31028
		[Token(Token = "0x4007934")]
		[FieldOffset(Offset = "0x88")]
		private UIStandardTabController m_TabCtrl;

		// Token: 0x020013DF RID: 5087
		[Token(Token = "0x20013DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC0F0", Offset = "0x10EC0F0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600537F RID: 21375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600537F")]
			[Address(RVA = "0x1A44A68", Offset = "0x1A44A68", VA = "0x7BBC244A68")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06005380 RID: 21376 RVA: 0x00018F00 File Offset: 0x00017100
			[Token(Token = "0x6005380")]
			[Address(RVA = "0x1A45638", Offset = "0x1A45638", VA = "0x7BBC245638")]
			internal bool <SelectItem>b__0(AnnoucementInfo e)
			{
				return default(bool);
			}

			// Token: 0x04007935 RID: 31029
			[Token(Token = "0x4007935")]
			[FieldOffset(Offset = "0x10")]
			public uint id;
		}

		// Token: 0x020013E0 RID: 5088
		[Token(Token = "0x20013E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC100", Offset = "0x10EC100")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06005381 RID: 21377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005381")]
			[Address(RVA = "0x1A4500C", Offset = "0x1A4500C", VA = "0x7BBC24500C")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06005382 RID: 21378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005382")]
			[Address(RVA = "0x1A45684", Offset = "0x1A45684", VA = "0x7BBC245684")]
			internal void <SetData>b__0()
			{
			}

			// Token: 0x04007936 RID: 31030
			[Token(Token = "0x4007936")]
			[FieldOffset(Offset = "0x10")]
			public StandardTabItemViewData tabData;

			// Token: 0x04007937 RID: 31031
			[Token(Token = "0x4007937")]
			[FieldOffset(Offset = "0x18")]
			public UIActivityAnnouncementController <>4__this;
		}
	}
}
