using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200191A RID: 6426
	[Token(Token = "0x200191A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5864", Offset = "0x10F5864")]
	internal class UIHudNameRedEnvelopeController : UIHudNameBaseController
	{
		// Token: 0x060081A5 RID: 33189 RVA: 0x00023520 File Offset: 0x00021720
		[Token(Token = "0x60081A5")]
		[Address(RVA = "0x17B768C", Offset = "0x17B768C", VA = "0x7BBBFB768C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A6")]
		[Address(RVA = "0x17B76DC", Offset = "0x17B76DC", VA = "0x7BBBFB76DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A7")]
		[Address(RVA = "0x17B773C", Offset = "0x17B773C", VA = "0x7BBBFB773C")]
		public void BindLevelObject(LevelRedEnvelope red)
		{
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x00023538 File Offset: 0x00021738
		[Token(Token = "0x60081A8")]
		[Address(RVA = "0x17B7744", Offset = "0x17B7744", VA = "0x7BBBFB7744", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081A9")]
		[Address(RVA = "0x17B7858", Offset = "0x17B7858", VA = "0x7BBBFB7858")]
		public void OnRedEnvelopeStatusChanged(bool isAlive)
		{
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x00023550 File Offset: 0x00021750
		[Token(Token = "0x60081AA")]
		[Address(RVA = "0x17B7AA8", Offset = "0x17B7AA8", VA = "0x7BBBFB7AA8", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081AB")]
		[Address(RVA = "0x17B7AB0", Offset = "0x17B7AB0", VA = "0x7BBBFB7AB0")]
		public UIHudNameRedEnvelopeController()
		{
		}

		// Token: 0x0400934A RID: 37706
		[Token(Token = "0x400934A")]
		[FieldOffset(Offset = "0xA8")]
		private LevelRedEnvelope bindedLevelObject;

		// Token: 0x0400934B RID: 37707
		[Token(Token = "0x400934B")]
		[FieldOffset(Offset = "0xB0")]
		private UIHudNameRedEnvelopeView m_View;
	}
}
