using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200136D RID: 4973
	[Token(Token = "0x200136D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB4E0", Offset = "0x10EB4E0")]
	public class UIFFWSTaskItemController : UIBaseController
	{
		// Token: 0x06004FAF RID: 20399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAF")]
		[Address(RVA = "0x228D3BC", Offset = "0x228D3BC", VA = "0x7BBCA8D3BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x000183A8 File Offset: 0x000165A8
		[Token(Token = "0x6004FB0")]
		[Address(RVA = "0x228D608", Offset = "0x228D608", VA = "0x7BBCA8D608")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x000183C0 File Offset: 0x000165C0
		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x228D658", Offset = "0x228D658", VA = "0x7BBCA8D658")]
		public uint GetActivityId()
		{
			return 0U;
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x228D684", Offset = "0x228D684", VA = "0x7BBCA8D684")]
		public Transform GetFromTransform()
		{
			return null;
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x228D500", Offset = "0x228D500", VA = "0x7BBCA8D500")]
		private void InitView()
		{
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x228B6E4", Offset = "0x228B6E4", VA = "0x7BBCA8B6E4")]
		public void SetSpData(object data)
		{
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x228B01C", Offset = "0x228B01C", VA = "0x7BBCA8B01C")]
		public void SetData(object data)
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x228D6C4", Offset = "0x228D6C4", VA = "0x7BBCA8D6C4")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x228D8C4", Offset = "0x228D8C4", VA = "0x7BBCA8D8C4")]
		public UIFFWSTaskItemController()
		{
		}

		// Token: 0x04007653 RID: 30291
		[Token(Token = "0x4007653")]
		[FieldOffset(Offset = "0x58")]
		private UIFFWSTaskItemView m_View;

		// Token: 0x04007654 RID: 30292
		[Token(Token = "0x4007654")]
		[FieldOffset(Offset = "0x60")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x04007655 RID: 30293
		[Token(Token = "0x4007655")]
		[FieldOffset(Offset = "0x68")]
		private ClientActivityDesc m_ClientActivityDesc;

		// Token: 0x04007656 RID: 30294
		[Token(Token = "0x4007656")]
		[FieldOffset(Offset = "0x70")]
		private UIStandardItemMiniController m_AwardCtrl;

		// Token: 0x04007657 RID: 30295
		[Token(Token = "0x4007657")]
		[FieldOffset(Offset = "0x78")]
		private EActivity.State m_State;

		// Token: 0x04007658 RID: 30296
		[Token(Token = "0x4007658")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_Data;
	}
}
