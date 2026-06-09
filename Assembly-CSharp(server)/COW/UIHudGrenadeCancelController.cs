using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018D5 RID: 6357
	[Token(Token = "0x20018D5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4F64", Offset = "0x10F4F64")]
	internal class UIHudGrenadeCancelController : UIHudButtonBaseController
	{
		// Token: 0x06007EC2 RID: 32450 RVA: 0x00022A28 File Offset: 0x00020C28
		[Token(Token = "0x6007EC2")]
		[Address(RVA = "0x197AB3C", Offset = "0x197AB3C", VA = "0x7BBC17AB3C")]
		public static Vector3 GetOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06007EC3 RID: 32451 RVA: 0x00022A40 File Offset: 0x00020C40
		[Token(Token = "0x6007EC3")]
		[Address(RVA = "0x197AC74", Offset = "0x197AC74", VA = "0x7BBC17AC74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC4")]
		[Address(RVA = "0x197ACC4", Offset = "0x197ACC4", VA = "0x7BBC17ACC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC5")]
		[Address(RVA = "0x197AE28", Offset = "0x197AE28", VA = "0x7BBC17AE28", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC6")]
		[Address(RVA = "0x197AF48", Offset = "0x197AF48", VA = "0x7BBC17AF48")]
		private void OnChangeVisible(params object[] param)
		{
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007EC7")]
		[Address(RVA = "0x197B0F4", Offset = "0x197B0F4", VA = "0x7BBC17B0F4", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC8")]
		[Address(RVA = "0x197B13C", Offset = "0x197B13C", VA = "0x7BBC17B13C")]
		public void SetDefaultPos(Vector3 pos)
		{
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EC9")]
		[Address(RVA = "0x197B148", Offset = "0x197B148", VA = "0x7BBC17B148")]
		public UIHudGrenadeCancelController()
		{
		}

		// Token: 0x040091F9 RID: 37369
		[Token(Token = "0x40091F9")]
		[FieldOffset(Offset = "0x60")]
		private UIHudCancelView m_View;

		// Token: 0x040091FA RID: 37370
		[Token(Token = "0x40091FA")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_pos;

		// Token: 0x040091FB RID: 37371
		[Token(Token = "0x40091FB")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 m_Offset;
	}
}
