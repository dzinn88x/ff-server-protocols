using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EC7 RID: 3783
	[Token(Token = "0x2000EC7")]
	public class EventDispatcher
	{
		// Token: 0x06003426 RID: 13350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003426")]
		[Address(RVA = "0x211261C", Offset = "0x211261C", VA = "0x7BBC91261C")]
		public EventDispatcher()
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003427")]
		[Address(RVA = "0x21126B8", Offset = "0x21126B8", VA = "0x7BBC9126B8")]
		public void DispatchEvent(uint eventID, params object[] data)
		{
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003428")]
		[Address(RVA = "0x2112E7C", Offset = "0x2112E7C", VA = "0x7BBC912E7C")]
		public void DispatchGEvent(uint eventID, GEvent data)
		{
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003429")]
		[Address(RVA = "0x2113640", Offset = "0x2113640", VA = "0x7BBC913640")]
		public void RegisterEvent(uint eventID, EventDispatcher.EventHandler eventHandler)
		{
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342A")]
		[Address(RVA = "0x2113788", Offset = "0x2113788", VA = "0x7BBC913788")]
		public void RegisterEvent(uint eventID, EventDispatcher.GEventHandler eventHandler)
		{
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342B")]
		[Address(RVA = "0x21138D0", Offset = "0x21138D0", VA = "0x7BBC9138D0")]
		public void UnRegisterEvent(uint eventID, EventDispatcher.EventHandler eventHandler)
		{
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600342C")]
		[Address(RVA = "0x2113A24", Offset = "0x2113A24", VA = "0x7BBC913A24")]
		public void UnRegisterGEvent(uint eventID, EventDispatcher.GEventHandler eventHandler)
		{
		}

		// Token: 0x04004801 RID: 18433
		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, EventDispatcher.EventHandler> m_EventDict;

		// Token: 0x04004802 RID: 18434
		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<uint, EventDispatcher.GEventHandler> m_GEventDict;

		// Token: 0x02000EC8 RID: 3784
		// (Invoke) Token: 0x0600342E RID: 13358
		[Token(Token = "0x2000EC8")]
		public delegate void EventHandler(params object[] data);

		// Token: 0x02000EC9 RID: 3785
		// (Invoke) Token: 0x06003432 RID: 13362
		[Token(Token = "0x2000EC9")]
		public delegate void GEventHandler(GEvent data);
	}
}
