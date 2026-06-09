using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019E4 RID: 6628
	[Token(Token = "0x20019E4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F72CC", Offset = "0x10F72CC")]
	internal class UILoadingController : UIBaseController
	{
		// Token: 0x060088F5 RID: 35061 RVA: 0x00024D68 File Offset: 0x00022F68
		[Token(Token = "0x60088F5")]
		[Address(RVA = "0x1CC88D8", Offset = "0x1CC88D8", VA = "0x7BBC4C88D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F6")]
		[Address(RVA = "0x1CC8928", Offset = "0x1CC8928", VA = "0x7BBC4C8928", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F7")]
		[Address(RVA = "0x1CC8AE8", Offset = "0x1CC8AE8", VA = "0x7BBC4C8AE8", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F8")]
		[Address(RVA = "0x1CC8BFC", Offset = "0x1CC8BFC", VA = "0x7BBC4C8BFC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088F9")]
		[Address(RVA = "0x1CC9178", Offset = "0x1CC9178", VA = "0x7BBC4C9178")]
		private void Update()
		{
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088FA")]
		[Address(RVA = "0x1CC8AE4", Offset = "0x1CC8AE4", VA = "0x7BBC4C8AE4")]
		private void UpdateProgressInfo()
		{
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088FB")]
		[Address(RVA = "0x1CC8C38", Offset = "0x1CC8C38", VA = "0x7BBC4C8C38")]
		private void RefreshLoadingBg()
		{
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088FC")]
		[Address(RVA = "0x1CC9658", Offset = "0x1CC9658", VA = "0x7BBC4C9658")]
		public UILoadingController()
		{
		}

		// Token: 0x0400972A RID: 38698
		[Token(Token = "0x400972A")]
		[FieldOffset(Offset = "0x58")]
		private UILoadingView m_View;

		// Token: 0x0400972B RID: 38699
		[Token(Token = "0x400972B")]
		[FieldOffset(Offset = "0x60")]
		private float m_Progress;

		// Token: 0x0400972C RID: 38700
		[Token(Token = "0x400972C")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_bgGO;

		// Token: 0x0400972D RID: 38701
		[Token(Token = "0x400972D")]
		[FieldOffset(Offset = "0x70")]
		private ResourceID m_bgUsedResID;
	}
}
