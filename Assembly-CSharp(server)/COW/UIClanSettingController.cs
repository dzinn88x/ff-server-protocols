using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200172E RID: 5934
	[Token(Token = "0x200172E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1A74", Offset = "0x10F1A74")]
	public class UIClanSettingController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06006EF9 RID: 28409 RVA: 0x0001F338 File Offset: 0x0001D538
		[Token(Token = "0x6006EF9")]
		[Address(RVA = "0x1D028F8", Offset = "0x1D028F8", VA = "0x7BBC5028F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFA")]
		[Address(RVA = "0x1D02948", Offset = "0x1D02948", VA = "0x7BBC502948", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFB")]
		[Address(RVA = "0x1D03A98", Offset = "0x1D03A98", VA = "0x7BBC503A98", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFC")]
		[Address(RVA = "0x1D03AE0", Offset = "0x1D03AE0", VA = "0x7BBC503AE0")]
		private void OnClickApprovalCondLevel()
		{
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0x1D03D40", Offset = "0x1D03D40", VA = "0x7BBC503D40")]
		private void OnClickApprovalCondRank()
		{
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFE")]
		[Address(RVA = "0x1D03FA0", Offset = "0x1D03FA0", VA = "0x7BBC503FA0")]
		private void OnClickArea()
		{
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EFF")]
		[Address(RVA = "0x1D04194", Offset = "0x1D04194", VA = "0x7BBC504194")]
		private void OnClickTag()
		{
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F00")]
		[Address(RVA = "0x1D04388", Offset = "0x1D04388", VA = "0x7BBC504388")]
		private void OnChangeSlogan()
		{
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F01")]
		[Address(RVA = "0x1D043F0", Offset = "0x1D043F0", VA = "0x7BBC5043F0")]
		private void OnSloganEditEnd()
		{
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F02")]
		[Address(RVA = "0x1D04424", Offset = "0x1D04424", VA = "0x7BBC504424")]
		private void OnChangeNotice()
		{
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F03")]
		[Address(RVA = "0x1D0448C", Offset = "0x1D0448C", VA = "0x7BBC50448C")]
		private void OnNoticeEditEnd()
		{
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F04")]
		[Address(RVA = "0x1D044C0", Offset = "0x1D044C0", VA = "0x7BBC5044C0")]
		private void OnClickSave()
		{
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F05")]
		[Address(RVA = "0x1D04C70", Offset = "0x1D04C70", VA = "0x7BBC504C70", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F06")]
		[Address(RVA = "0x1D035DC", Offset = "0x1D035DC", VA = "0x7BBC5035DC")]
		private void UpdateView()
		{
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x0001F350 File Offset: 0x0001D550
		[Token(Token = "0x6006F07")]
		[Address(RVA = "0x1D04FD0", Offset = "0x1D04FD0", VA = "0x7BBC504FD0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F08")]
		[Address(RVA = "0x1D04E40", Offset = "0x1D04E40", VA = "0x7BBC504E40")]
		private void SetAuditPopupLabel(uint entryType)
		{
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F09")]
		[Address(RVA = "0x1D05014", Offset = "0x1D05014", VA = "0x7BBC505014")]
		private void OnChangeAudit()
		{
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0x1D05134", Offset = "0x1D05134", VA = "0x7BBC505134")]
		public UIClanSettingController()
		{
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0x1D0513C", Offset = "0x1D0513C", VA = "0x7BBC50513C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11413BC", Offset = "0x11413BC")]
		private void <OnClickApprovalCondLevel>b__16_0(List<string> ids)
		{
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x1D05294", Offset = "0x1D05294", VA = "0x7BBC505294")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11413CC", Offset = "0x11413CC")]
		private void <OnClickApprovalCondRank>b__17_0(List<string> ids)
		{
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0x1D053EC", Offset = "0x1D053EC", VA = "0x7BBC5053EC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11413DC", Offset = "0x11413DC")]
		private void <OnClickArea>b__18_0(List<string> ids)
		{
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0x1D054B8", Offset = "0x1D054B8", VA = "0x7BBC5054B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11413EC", Offset = "0x11413EC")]
		private void <OnClickTag>b__19_0(List<string> ids)
		{
		}

		// Token: 0x0400894B RID: 35147
		[Token(Token = "0x400894B")]
		[FieldOffset(Offset = "0x98")]
		private UIClanSettingView m_View;

		// Token: 0x0400894C RID: 35148
		[Token(Token = "0x400894C")]
		[FieldOffset(Offset = "0xA0")]
		private EClan.EntryType m_CurAuditType;

		// Token: 0x0400894D RID: 35149
		[Token(Token = "0x400894D")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelClan m_ModelClan;

		// Token: 0x0400894E RID: 35150
		[Token(Token = "0x400894E")]
		private const int SLOGAN_MIN_LENGTH = 3;

		// Token: 0x0400894F RID: 35151
		[Token(Token = "0x400894F")]
		private const int SLOGAN_MAX_LENGTH = 20;

		// Token: 0x04008950 RID: 35152
		[Token(Token = "0x4008950")]
		private const int ANNOUNCEMENT_MAX_LENGTH = 80;

		// Token: 0x04008951 RID: 35153
		[Token(Token = "0x4008951")]
		[FieldOffset(Offset = "0xB0")]
		private BoxCollider m_SloganCollider;

		// Token: 0x04008952 RID: 35154
		[Token(Token = "0x4008952")]
		[FieldOffset(Offset = "0xB8")]
		private BoxCollider m_NoticeCollider;

		// Token: 0x04008953 RID: 35155
		[Token(Token = "0x4008953")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> m_TagIDs;

		// Token: 0x04008954 RID: 35156
		[Token(Token = "0x4008954")]
		[FieldOffset(Offset = "0xC8")]
		private List<string> m_AreaIDs;

		// Token: 0x04008955 RID: 35157
		[Token(Token = "0x4008955")]
		[FieldOffset(Offset = "0xD0")]
		private ClanInfo m_ClanInfo;

		// Token: 0x04008956 RID: 35158
		[Token(Token = "0x4008956")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_RankCondition;

		// Token: 0x04008957 RID: 35159
		[Token(Token = "0x4008957")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_LevelCondition;
	}
}
