using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A69 RID: 6761
	[Token(Token = "0x2001A69")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F81E4", Offset = "0x10F81E4")]
	public class UIMatchMakingWatingController : UIPopupWindowController
	{
		// Token: 0x06008E5A RID: 36442 RVA: 0x00025FC8 File Offset: 0x000241C8
		[Token(Token = "0x6008E5A")]
		[Address(RVA = "0x1478FCC", Offset = "0x1478FCC", VA = "0x7BBBC78FCC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E5B")]
		[Address(RVA = "0x147901C", Offset = "0x147901C", VA = "0x7BBBC7901C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E5C")]
		[Address(RVA = "0x1479224", Offset = "0x1479224", VA = "0x7BBBC79224", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E5D")]
		[Address(RVA = "0x14792F0", Offset = "0x14792F0", VA = "0x7BBBC792F0")]
		private void Update()
		{
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E5E")]
		[Address(RVA = "0x1479438", Offset = "0x1479438", VA = "0x7BBBC79438")]
		private void OnSimulateClickBtnCancel(params object[] data)
		{
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E5F")]
		[Address(RVA = "0x147943C", Offset = "0x147943C", VA = "0x7BBBC7943C")]
		protected void OnBtnCancel()
		{
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x00025FE0 File Offset: 0x000241E0
		[Token(Token = "0x6008E60")]
		[Address(RVA = "0x1479474", Offset = "0x1479474", VA = "0x7BBBC79474", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008E61")]
		[Address(RVA = "0x1479540", Offset = "0x1479540", VA = "0x7BBBC79540")]
		public UIMatchMakingWatingController()
		{
		}

		// Token: 0x040099FF RID: 39423
		[Token(Token = "0x40099FF")]
		[FieldOffset(Offset = "0x98")]
		private UIMatchMakingWaitingView m_View;

		// Token: 0x04009A00 RID: 39424
		[Token(Token = "0x4009A00")]
		[FieldOffset(Offset = "0xA0")]
		private float m_Time;

		// Token: 0x04009A01 RID: 39425
		[Token(Token = "0x4009A01")]
		[FieldOffset(Offset = "0xA8")]
		public Action OnCancel;
	}
}
