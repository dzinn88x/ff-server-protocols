using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013E9 RID: 5097
	[Token(Token = "0x20013E9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC1E8", Offset = "0x10EC1E8")]
	public class UIActivityContentController : UIBaseController
	{
		// Token: 0x060053C4 RID: 21444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x1A3E938", Offset = "0x1A3E938", VA = "0x7BBC23E938", Slot = "28")]
		public virtual void SetData(object data)
		{
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x1A3CE38", Offset = "0x1A3CE38", VA = "0x7BBC23CE38", Slot = "29")]
		public virtual void Reload()
		{
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x1A4B3C0", Offset = "0x1A4B3C0", VA = "0x7BBC24B3C0")]
		public void SetTime(ActivityGroupDesc groupDesc, UILabel time)
		{
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00019008 File Offset: 0x00017208
		[Token(Token = "0x60053C7")]
		[Address(RVA = "0x1A4B468", Offset = "0x1A4B468", VA = "0x7BBC24B468")]
		public bool SetProgressBar(ActivityGroupDesc groupDesc, UILabel tips, UIProgressBar progressBar)
		{
			return default(bool);
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x1A3CEAC", Offset = "0x1A3CEAC", VA = "0x7BBC23CEAC")]
		public UIActivityContentController()
		{
		}
	}
}
