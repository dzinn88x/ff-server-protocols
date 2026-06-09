using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001560 RID: 5472
	[Token(Token = "0x2001560")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE6AC", Offset = "0x10EE6AC")]
	public class UIExchangeMallClanItemController : UIExchangeMallItemController
	{
		// Token: 0x06005EDF RID: 24287 RVA: 0x0001B738 File Offset: 0x00019938
		[Token(Token = "0x6005EDF")]
		[Address(RVA = "0x1E7D9FC", Offset = "0x1E7D9FC", VA = "0x7BBC67D9FC")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE0")]
		[Address(RVA = "0x1E7DA4C", Offset = "0x1E7DA4C", VA = "0x7BBC67DA4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x1E7DBB8", Offset = "0x1E7DBB8", VA = "0x7BBC67DBB8", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x1E7DC48", Offset = "0x1E7DC48", VA = "0x7BBC67DC48", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x1E7E070", Offset = "0x1E7E070", VA = "0x7BBC67E070", Slot = "44")]
		protected override void RefreshItemBGState()
		{
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x1E7E144", Offset = "0x1E7E144", VA = "0x7BBC67E144")]
		private void SetComposeIconColor(UISprite boxSprite, Color color)
		{
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x1E7DDA8", Offset = "0x1E7DDA8", VA = "0x7BBC67DDA8")]
		private void CheckIsReachClanLevel()
		{
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x1E7DDD0", Offset = "0x1E7DDD0", VA = "0x7BBC67DDD0")]
		private void RefreshClanLevelTitle()
		{
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x1E7E274", Offset = "0x1E7E274", VA = "0x7BBC67E274")]
		public UIExchangeMallClanItemController()
		{
		}

		// Token: 0x04007FDA RID: 32730
		[Token(Token = "0x4007FDA")]
		[FieldOffset(Offset = "0x230")]
		private bool m_IsReachClanLevel;

		// Token: 0x04007FDB RID: 32731
		[Token(Token = "0x4007FDB")]
		[FieldOffset(Offset = "0x234")]
		private uint m_MyClanLevel;
	}
}
