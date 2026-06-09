using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD
{
	// Token: 0x02002662 RID: 9826
	[Token(Token = "0x2002662")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE1B0", Offset = "0x10FE1B0")]
	public class UIHudLockedWarningController : UIBaseController
	{
		// Token: 0x0600CAAD RID: 51885 RVA: 0x00036810 File Offset: 0x00034A10
		[Token(Token = "0x600CAAD")]
		[Address(RVA = "0x176AE34", Offset = "0x176AE34", VA = "0x7BBBF6AE34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAE")]
		[Address(RVA = "0x176AE84", Offset = "0x176AE84", VA = "0x7BBBF6AE84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAF")]
		[Address(RVA = "0x176AEE8", Offset = "0x176AEE8", VA = "0x7BBBF6AEE8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB0")]
		[Address(RVA = "0x176AF1C", Offset = "0x176AF1C", VA = "0x7BBBF6AF1C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB1")]
		[Address(RVA = "0x176B120", Offset = "0x176B120", VA = "0x7BBBF6B120", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB2")]
		[Address(RVA = "0x176B148", Offset = "0x176B148", VA = "0x7BBBF6B148")]
		internal void \u0081d(LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB3")]
		[Address(RVA = "0x176B288", Offset = "0x176B288", VA = "0x7BBBF6B288")]
		internal void RF(LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB4")]
		[Address(RVA = "0x176B498", Offset = "0x176B498", VA = "0x7BBBF6B498")]
		private void LJqkO[W()
		{
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB5")]
		[Address(RVA = "0x176B51C", Offset = "0x176B51C", VA = "0x7BBBF6B51C")]
		private void Update()
		{
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB6")]
		[Address(RVA = "0x176B8F4", Offset = "0x176B8F4", VA = "0x7BBBF6B8F4")]
		private void jAYAS\u0081R(Entity VT`lIxO, LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB7")]
		[Address(RVA = "0x176B370", Offset = "0x176B370", VA = "0x7BBBF6B370")]
		private void ULEYhwH(LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB8")]
		[Address(RVA = "0x176AF44", Offset = "0x176AF44", VA = "0x7BBBF6AF44")]
		private void WnZrben()
		{
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB9")]
		[Address(RVA = "0x176BA6C", Offset = "0x176BA6C", VA = "0x7BBBF6BA6C")]
		public UIHudLockedWarningController()
		{
		}

		// Token: 0x0400FF24 RID: 65316
		[Token(Token = "0x400FF24")]
		[FieldOffset(Offset = "0x58")]
		private UIHudLockedWarningView p|r\u007Fnuf;

		// Token: 0x0400FF25 RID: 65317
		[Token(Token = "0x400FF25")]
		[FieldOffset(Offset = "0x60")]
		private List<LevelMissileBase> ]awrjpd;

		// Token: 0x0400FF26 RID: 65318
		[Token(Token = "0x400FF26")]
		private const float fFhm^ag = 30f;

		// Token: 0x0400FF27 RID: 65319
		[Token(Token = "0x400FF27")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<LevelMissileBase, GameObject> A}W\u0081CN\u0082;

		// Token: 0x0400FF28 RID: 65320
		[Token(Token = "0x400FF28")]
		[FieldOffset(Offset = "0x70")]
		private AbDr`s tnLFHuU;
	}
}
