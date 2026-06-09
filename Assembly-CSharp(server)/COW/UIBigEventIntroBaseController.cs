using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001417 RID: 5143
	[Token(Token = "0x2001417")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC608", Offset = "0x10EC608")]
	public abstract class UIBigEventIntroBaseController : UIBaseController
	{
		// Token: 0x060054C9 RID: 21705 RVA: 0x00019500 File Offset: 0x00017700
		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x14287F8", Offset = "0x14287F8", VA = "0x7BBBC287F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x1428860", Offset = "0x1428860", VA = "0x7BBBC28860", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x1428868", Offset = "0x1428868", VA = "0x7BBBC28868", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x1428870", Offset = "0x1428870", VA = "0x7BBBC28870", Slot = "28")]
		public virtual void SetView(ELimitedEvent.EventID eventId, EBigEventIntroTiming timing, List<EventDelegate> eds)
		{
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x1428B2C", Offset = "0x1428B2C", VA = "0x7BBBC28B2C")]
		protected UIBigEventIntroBaseController()
		{
		}
	}
}
