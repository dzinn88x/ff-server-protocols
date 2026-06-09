using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025FE RID: 9726
	[Token(Token = "0x20025FE")]
	public class UICountDownLabel : MonoBehaviour
	{
		// Token: 0x0600C8C3 RID: 51395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C3")]
		[Address(RVA = "0x1818DF8", Offset = "0x1818DF8", VA = "0x7BBC018DF8")]
		public void SetCountDownEndTime(ulong end, bool shortDisplay)
		{
		}

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C4")]
		[Address(RVA = "0x180F61C", Offset = "0x180F61C", VA = "0x7BBC00F61C")]
		public void SetCountDownEndTime(ulong end, string prefix = "", string suffix = "", bool formated = true, [Optional] OnStarted onStarted, [Optional] OnFinished onFinished, bool shortDisplay = true, bool isStarted = true)
		{
		}

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C5")]
		[Address(RVA = "0x1819124", Offset = "0x1819124", VA = "0x7BBC019124")]
		public void SetCountDownEndTime(CountDownConfig config)
		{
		}

		// Token: 0x0600C8C6 RID: 51398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C6")]
		[Address(RVA = "0x1819214", Offset = "0x1819214", VA = "0x7BBC019214")]
		public void SetUpdateDelegate(OnUpdate callback)
		{
		}

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C7")]
		[Address(RVA = "0x181921C", Offset = "0x181921C", VA = "0x7BBC01921C")]
		private void OnEnable()
		{
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C8")]
		[Address(RVA = "0x18192AC", Offset = "0x18192AC", VA = "0x7BBC0192AC")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8C9")]
		[Address(RVA = "0x1818E84", Offset = "0x1818E84", VA = "0x7BBC018E84")]
		private void CountDown()
		{
		}

		// Token: 0x0600C8CA RID: 51402 RVA: 0x00036270 File Offset: 0x00034470
		[Token(Token = "0x600C8CA")]
		[Address(RVA = "0x18192B0", Offset = "0x18192B0", VA = "0x7BBC0192B0")]
		public bool IsDuringCountDown()
		{
			return default(bool);
		}

		// Token: 0x0600C8CB RID: 51403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CB")]
		[Address(RVA = "0x181898C", Offset = "0x181898C", VA = "0x7BBC01898C")]
		public void Cancel()
		{
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8CC")]
		[Address(RVA = "0x18192C0", Offset = "0x18192C0", VA = "0x7BBC0192C0")]
		public UICountDownLabel()
		{
		}

		// Token: 0x0400FB20 RID: 64288
		[Token(Token = "0x400FB20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UILabel m_Label;

		// Token: 0x0400FB21 RID: 64289
		[Token(Token = "0x400FB21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ulong endTime;

		// Token: 0x0400FB22 RID: 64290
		[Token(Token = "0x400FB22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_Prefix;

		// Token: 0x0400FB23 RID: 64291
		[Token(Token = "0x400FB23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_Suffix;

		// Token: 0x0400FB24 RID: 64292
		[Token(Token = "0x400FB24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Formated;

		// Token: 0x0400FB25 RID: 64293
		[Token(Token = "0x400FB25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_ShortDisplay;

		// Token: 0x0400FB26 RID: 64294
		[Token(Token = "0x400FB26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OnStarted m_OnStarted;

		// Token: 0x0400FB27 RID: 64295
		[Token(Token = "0x400FB27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public OnFinished m_OnFinished;

		// Token: 0x0400FB28 RID: 64296
		[Token(Token = "0x400FB28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OnUpdate m_OnUpdate;

		// Token: 0x0400FB29 RID: 64297
		[Token(Token = "0x400FB29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private uint m_DelayCall;
	}
}
