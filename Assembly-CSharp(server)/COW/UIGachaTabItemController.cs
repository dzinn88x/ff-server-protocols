using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200181F RID: 6175
	[Token(Token = "0x200181F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F36DC", Offset = "0x10F36DC")]
	public class UIGachaTabItemController : UIBaseController
	{
		// Token: 0x06007875 RID: 30837 RVA: 0x00021390 File Offset: 0x0001F590
		[Token(Token = "0x6007875")]
		[Address(RVA = "0x1FA24BC", Offset = "0x1FA24BC", VA = "0x7BBC7A24BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007876")]
		[Address(RVA = "0x1FA250C", Offset = "0x1FA250C", VA = "0x7BBC7A250C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007877")]
		[Address(RVA = "0x1FA29AC", Offset = "0x1FA29AC", VA = "0x7BBC7A29AC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007878")]
		[Address(RVA = "0x1FA2CBC", Offset = "0x1FA2CBC", VA = "0x7BBC7A2CBC", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007879")]
		[Address(RVA = "0x1FA2D08", Offset = "0x1FA2D08", VA = "0x7BBC7A2D08")]
		public void OnUIGachaShow()
		{
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787A")]
		[Address(RVA = "0x1FA2D7C", Offset = "0x1FA2D7C", VA = "0x7BBC7A2D7C")]
		public void OnUIGachaHide()
		{
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787B")]
		[Address(RVA = "0x1FA2E40", Offset = "0x1FA2E40", VA = "0x7BBC7A2E40")]
		public void SetViewData(int curGachaIdx)
		{
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787C")]
		[Address(RVA = "0x1FA3288", Offset = "0x1FA3288", VA = "0x7BBC7A3288")]
		public void RefreshUI(bool isSelected)
		{
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787D")]
		[Address(RVA = "0x1FA3424", Offset = "0x1FA3424", VA = "0x7BBC7A3424")]
		private void InitBGSprite()
		{
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787E")]
		[Address(RVA = "0x1FA34DC", Offset = "0x1FA34DC", VA = "0x7BBC7A34DC")]
		private void OnGachaTabItemBtnClick()
		{
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600787F")]
		[Address(RVA = "0x1FA3604", Offset = "0x1FA3604", VA = "0x7BBC7A3604")]
		public void SetSelecetState(bool isSelected)
		{
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007880")]
		[Address(RVA = "0x1FA2600", Offset = "0x1FA2600", VA = "0x7BBC7A2600")]
		private void InitAnimState()
		{
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007881")]
		[Address(RVA = "0x1FA2F08", Offset = "0x1FA2F08", VA = "0x7BBC7A2F08")]
		private void InitCDNTex()
		{
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007882")]
		[Address(RVA = "0x1FA37F0", Offset = "0x1FA37F0", VA = "0x7BBC7A37F0")]
		private void HideDefaultSprite()
		{
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007883")]
		[Address(RVA = "0x1FA328C", Offset = "0x1FA328C", VA = "0x7BBC7A328C")]
		private void RefreshNewTip()
		{
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007884")]
		[Address(RVA = "0x1FA384C", Offset = "0x1FA384C", VA = "0x7BBC7A384C")]
		public UIGachaTabItemController()
		{
		}

		// Token: 0x04008E46 RID: 36422
		[Token(Token = "0x4008E46")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public ulong startTime;

		// Token: 0x04008E47 RID: 36423
		[Token(Token = "0x4008E47")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int pageDetentionTime;

		// Token: 0x04008E48 RID: 36424
		[Token(Token = "0x4008E48")]
		[FieldOffset(Offset = "0x68")]
		private UIGachaTabItemView m_View;

		// Token: 0x04008E49 RID: 36425
		[Token(Token = "0x4008E49")]
		[FieldOffset(Offset = "0x70")]
		private int m_Idx;

		// Token: 0x04008E4A RID: 36426
		[Token(Token = "0x4008E4A")]
		[FieldOffset(Offset = "0x78")]
		private GachaDesc m_Desc;

		// Token: 0x04008E4B RID: 36427
		[Token(Token = "0x4008E4B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsSelected;

		// Token: 0x04008E4C RID: 36428
		[Token(Token = "0x4008E4C")]
		[FieldOffset(Offset = "0x88")]
		private AnimationState[] scaleStateList;

		// Token: 0x04008E4D RID: 36429
		[Token(Token = "0x4008E4D")]
		private const string m_IconPrefix = "FF_Lottery_Tab0";
	}
}
