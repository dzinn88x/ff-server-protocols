using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001402 RID: 5122
	[Token(Token = "0x2001402")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC460", Offset = "0x10EC460")]
	public class UIAcitivtyPreloginContentController : UIActivityContentController
	{
		// Token: 0x0600544F RID: 21583 RVA: 0x000192A8 File Offset: 0x000174A8
		[Token(Token = "0x600544F")]
		[Address(RVA = "0x1A3C85C", Offset = "0x1A3C85C", VA = "0x7BBC23C85C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005450")]
		[Address(RVA = "0x1A3C8AC", Offset = "0x1A3C8AC", VA = "0x7BBC23C8AC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005451")]
		[Address(RVA = "0x1A3C964", Offset = "0x1A3C964", VA = "0x7BBC23C964", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005452")]
		[Address(RVA = "0x1A3C9F8", Offset = "0x1A3C9F8", VA = "0x7BBC23C9F8")]
		private void UpdateActivityInfo()
		{
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005453")]
		[Address(RVA = "0x1A3C9FC", Offset = "0x1A3C9FC", VA = "0x7BBC23C9FC")]
		private void CreateEventDescList()
		{
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005454")]
		[Address(RVA = "0x1A3CBD4", Offset = "0x1A3CBD4", VA = "0x7BBC23CBD4")]
		private ActivityPreloginDescription CreateEventDesc(ClientActivityDesc desc)
		{
			return null;
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005455")]
		[Address(RVA = "0x1A3CD10", Offset = "0x1A3CD10", VA = "0x7BBC23CD10", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005456")]
		[Address(RVA = "0x1A3CE3C", Offset = "0x1A3CE3C", VA = "0x7BBC23CE3C")]
		public UIAcitivtyPreloginContentController()
		{
		}

		// Token: 0x040079C2 RID: 31170
		[Token(Token = "0x40079C2")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityPreloginContentView m_View;

		// Token: 0x040079C3 RID: 31171
		[Token(Token = "0x40079C3")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040079C4 RID: 31172
		[Token(Token = "0x40079C4")]
		[FieldOffset(Offset = "0x68")]
		private ActivityGroupDesc m_GroupDesc;

		// Token: 0x040079C5 RID: 31173
		[Token(Token = "0x40079C5")]
		[FieldOffset(Offset = "0x70")]
		private List<ActivityPreloginDescription> m_AwardDescUIs;
	}
}
