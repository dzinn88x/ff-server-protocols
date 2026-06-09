using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BB5 RID: 7093
	[Token(Token = "0x2001BB5")]
	public class UITokenTipsController : UIPopupWindowController
	{
		// Token: 0x06009915 RID: 39189 RVA: 0x00028500 File Offset: 0x00026700
		[Token(Token = "0x6009915")]
		[Address(RVA = "0x1F561D8", Offset = "0x1F561D8", VA = "0x7BBC7561D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009916")]
		[Address(RVA = "0x1F56228", Offset = "0x1F56228", VA = "0x7BBC756228", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009917")]
		[Address(RVA = "0x1F56388", Offset = "0x1F56388", VA = "0x7BBC756388", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x00028518 File Offset: 0x00026718
		[Token(Token = "0x6009918")]
		[Address(RVA = "0x1F56454", Offset = "0x1F56454", VA = "0x7BBC756454", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009919")]
		[Address(RVA = "0x1F5645C", Offset = "0x1F5645C", VA = "0x7BBC75645C")]
		private void OnNavigationPushed(params object[] args)
		{
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991A")]
		[Address(RVA = "0x1F491D8", Offset = "0x1F491D8", VA = "0x7BBC7491D8")]
		public void SetData(Vector3 itemPos, string descrip, List<BigEventTokenTipsDesc> tokenTipsList, Vector3 offset)
		{
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991B")]
		[Address(RVA = "0x1F56464", Offset = "0x1F56464", VA = "0x7BBC756464")]
		private void AdjustView(Vector3 itemPos, Vector3 offset)
		{
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991C")]
		[Address(RVA = "0x1F56BE0", Offset = "0x1F56BE0", VA = "0x7BBC756BE0")]
		public UITokenTipsController()
		{
		}

		// Token: 0x0400A098 RID: 41112
		[Token(Token = "0x400A098")]
		[FieldOffset(Offset = "0x98")]
		private UITokenTipsView m_View;

		// Token: 0x0400A099 RID: 41113
		[Token(Token = "0x400A099")]
		[FieldOffset(Offset = "0xA0")]
		private int m_TopAndBottomPadding;
	}
}
