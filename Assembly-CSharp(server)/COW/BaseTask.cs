using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025CF RID: 9679
	[Token(Token = "0x20025CF")]
	public class BaseTask : MonoBehaviour
	{
		// Token: 0x0600C6FE RID: 50942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6FE")]
		[Address(RVA = "0x21D6568", Offset = "0x21D6568", VA = "0x7BBC9D6568", Slot = "4")]
		public virtual void OnStart()
		{
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6FF")]
		[Address(RVA = "0x21D675C", Offset = "0x21D675C", VA = "0x7BBC9D675C")]
		public void ShowSuccess()
		{
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C700")]
		[Address(RVA = "0x21D6874", Offset = "0x21D6874", VA = "0x7BBC9D6874")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147DB4", Offset = "0x1147DB4")]
		private IEnumerator SuccessCoroutine()
		{
			return null;
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C701")]
		[Address(RVA = "0x21D6914", Offset = "0x21D6914", VA = "0x7BBC9D6914", Slot = "5")]
		public virtual void OnSuccess()
		{
		}

		// Token: 0x0600C702 RID: 50946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C702")]
		[Address(RVA = "0x21D6D24", Offset = "0x21D6D24", VA = "0x7BBC9D6D24")]
		public void ShowFailure()
		{
		}

		// Token: 0x0600C703 RID: 50947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C703")]
		[Address(RVA = "0x21D6DD0", Offset = "0x21D6DD0", VA = "0x7BBC9D6DD0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147E18", Offset = "0x1147E18")]
		private IEnumerator FailureCoroutine()
		{
			return null;
		}

		// Token: 0x0600C704 RID: 50948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C704")]
		[Address(RVA = "0x21D6E70", Offset = "0x21D6E70", VA = "0x7BBC9D6E70", Slot = "6")]
		public virtual void OnFailure()
		{
		}

		// Token: 0x0600C705 RID: 50949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C705")]
		[Address(RVA = "0x21D6E74", Offset = "0x21D6E74", VA = "0x7BBC9D6E74")]
		public void SetCompleteCallBack(BaseTask.CompleteCallBack value, BaseTask.CompleteCallBack post)
		{
		}

		// Token: 0x0600C706 RID: 50950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C706")]
		[Address(RVA = "0x21D6E7C", Offset = "0x21D6E7C", VA = "0x7BBC9D6E7C", Slot = "7")]
		public virtual void OnPostSuccess()
		{
		}

		// Token: 0x0600C707 RID: 50951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C707")]
		[Address(RVA = "0x21D6E8C", Offset = "0x21D6E8C", VA = "0x7BBC9D6E8C")]
		protected void PlayAnimation()
		{
		}

		// Token: 0x0600C708 RID: 50952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C708")]
		[Address(RVA = "0x21D6F10", Offset = "0x21D6F10", VA = "0x7BBC9D6F10")]
		protected void StopAnimation()
		{
		}

		// Token: 0x0600C709 RID: 50953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C709")]
		[Address(RVA = "0x21D6F94", Offset = "0x21D6F94", VA = "0x7BBC9D6F94")]
		protected void PlayLoopSound()
		{
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70A")]
		[Address(RVA = "0x21D703C", Offset = "0x21D703C", VA = "0x7BBC9D703C")]
		protected void StopLoopSound()
		{
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70B")]
		[Address(RVA = "0x21D70E8", Offset = "0x21D70E8", VA = "0x7BBC9D70E8", Slot = "8")]
		public virtual void Pause()
		{
		}

		// Token: 0x0600C70C RID: 50956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70C")]
		[Address(RVA = "0x21D70EC", Offset = "0x21D70EC", VA = "0x7BBC9D70EC", Slot = "9")]
		public virtual void Resume()
		{
		}

		// Token: 0x0600C70D RID: 50957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70D")]
		[Address(RVA = "0x21D70F0", Offset = "0x21D70F0", VA = "0x7BBC9D70F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C70E RID: 50958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70E")]
		[Address(RVA = "0x21D70F4", Offset = "0x21D70F4", VA = "0x7BBC9D70F4")]
		public BaseTask()
		{
		}

		// Token: 0x0400F95A RID: 63834
		[Token(Token = "0x400F95A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject SuccessObj;

		// Token: 0x0400F95B RID: 63835
		[Token(Token = "0x400F95B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject FailureObj;

		// Token: 0x0400F95C RID: 63836
		[Token(Token = "0x400F95C")]
		[FieldOffset(Offset = "0x28")]
		public Animation[] animations;

		// Token: 0x0400F95D RID: 63837
		[Token(Token = "0x400F95D")]
		[FieldOffset(Offset = "0x30")]
		public float SuccessShowTime;

		// Token: 0x0400F95E RID: 63838
		[Token(Token = "0x400F95E")]
		[FieldOffset(Offset = "0x34")]
		public float FailureShowTime;

		// Token: 0x0400F95F RID: 63839
		[Token(Token = "0x400F95F")]
		[FieldOffset(Offset = "0x38")]
		public string successSound;

		// Token: 0x0400F960 RID: 63840
		[Token(Token = "0x400F960")]
		[FieldOffset(Offset = "0x40")]
		public string loopSound;

		// Token: 0x0400F961 RID: 63841
		[Token(Token = "0x400F961")]
		[FieldOffset(Offset = "0x48")]
		private BaseTask.CompleteCallBack callBack;

		// Token: 0x0400F962 RID: 63842
		[Token(Token = "0x400F962")]
		[FieldOffset(Offset = "0x50")]
		private BaseTask.CompleteCallBack postCallBack;

		// Token: 0x0400F963 RID: 63843
		[Token(Token = "0x400F963")]
		[FieldOffset(Offset = "0x58")]
		private ResourceID m_resSuccessSound;

		// Token: 0x0400F964 RID: 63844
		[Token(Token = "0x400F964")]
		[FieldOffset(Offset = "0x5C")]
		private ResourceID m_loopSound;

		// Token: 0x0400F965 RID: 63845
		[Token(Token = "0x400F965")]
		[FieldOffset(Offset = "0x60")]
		private AudioResource m_loopAudio;

		// Token: 0x020025D0 RID: 9680
		// (Invoke) Token: 0x0600C710 RID: 50960
		[Token(Token = "0x20025D0")]
		public delegate void CompleteCallBack();

		// Token: 0x020025D1 RID: 9681
		[Token(Token = "0x20025D1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE64", Offset = "0x10FDE64")]
		private sealed class <SuccessCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C713 RID: 50963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C713")]
			[Address(RVA = "0x21D68E8", Offset = "0x21D68E8", VA = "0x7BBC9D68E8")]
			[DebuggerHidden]
			public <SuccessCoroutine>d__15(int <>1__state)
			{
			}

			// Token: 0x0600C714 RID: 50964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C714")]
			[Address(RVA = "0x21D724C", Offset = "0x21D724C", VA = "0x7BBC9D724C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C715 RID: 50965 RVA: 0x00035640 File Offset: 0x00033840
			[Token(Token = "0x600C715")]
			[Address(RVA = "0x21D7250", Offset = "0x21D7250", VA = "0x7BBC9D7250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x0600C716 RID: 50966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDA")]
			private object Current
			{
				[Token(Token = "0x600C716")]
				[Address(RVA = "0x21D731C", Offset = "0x21D731C", VA = "0x7BBC9D731C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C717 RID: 50967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C717")]
			[Address(RVA = "0x21D7324", Offset = "0x21D7324", VA = "0x7BBC9D7324", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x0600C718 RID: 50968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDB")]
			private object Current
			{
				[Token(Token = "0x600C718")]
				[Address(RVA = "0x21D738C", Offset = "0x21D738C", VA = "0x7BBC9D738C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400F966 RID: 63846
			[Token(Token = "0x400F966")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400F967 RID: 63847
			[Token(Token = "0x400F967")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400F968 RID: 63848
			[Token(Token = "0x400F968")]
			[FieldOffset(Offset = "0x20")]
			public BaseTask <>4__this;
		}

		// Token: 0x020025D2 RID: 9682
		[Token(Token = "0x20025D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE74", Offset = "0x10FDE74")]
		private sealed class <FailureCoroutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600C719 RID: 50969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C719")]
			[Address(RVA = "0x21D6E44", Offset = "0x21D6E44", VA = "0x7BBC9D6E44")]
			[DebuggerHidden]
			public <FailureCoroutine>d__18(int <>1__state)
			{
			}

			// Token: 0x0600C71A RID: 50970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C71A")]
			[Address(RVA = "0x21D7104", Offset = "0x21D7104", VA = "0x7BBC9D7104", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600C71B RID: 50971 RVA: 0x00035658 File Offset: 0x00033858
			[Token(Token = "0x600C71B")]
			[Address(RVA = "0x21D7108", Offset = "0x21D7108", VA = "0x7BBC9D7108", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x0600C71C RID: 50972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDC")]
			private object Current
			{
				[Token(Token = "0x600C71C")]
				[Address(RVA = "0x21D71D4", Offset = "0x21D71D4", VA = "0x7BBC9D71D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600C71D RID: 50973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C71D")]
			[Address(RVA = "0x21D71DC", Offset = "0x21D71DC", VA = "0x7BBC9D71DC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x0600C71E RID: 50974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDD")]
			private object Current
			{
				[Token(Token = "0x600C71E")]
				[Address(RVA = "0x21D7244", Offset = "0x21D7244", VA = "0x7BBC9D7244", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400F969 RID: 63849
			[Token(Token = "0x400F969")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400F96A RID: 63850
			[Token(Token = "0x400F96A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400F96B RID: 63851
			[Token(Token = "0x400F96B")]
			[FieldOffset(Offset = "0x20")]
			public BaseTask <>4__this;
		}
	}
}
