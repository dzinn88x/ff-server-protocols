using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016C9 RID: 5833
	[Token(Token = "0x20016C9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0C9C", Offset = "0x10F0C9C")]
	public class UIAvatarSkillTipsController : UIBaseController
	{
		// Token: 0x06006B38 RID: 27448 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		[Token(Token = "0x6006B38")]
		[Address(RVA = "0x1E4F358", Offset = "0x1E4F358", VA = "0x7BBC64F358")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B39")]
		[Address(RVA = "0x1E4F3A8", Offset = "0x1E4F3A8", VA = "0x7BBC64F3A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3A")]
		[Address(RVA = "0x1E48C9C", Offset = "0x1E48C9C", VA = "0x7BBC648C9C")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3B")]
		[Address(RVA = "0x1E4F544", Offset = "0x1E4F544", VA = "0x7BBC64F544", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3C")]
		[Address(RVA = "0x1E4F654", Offset = "0x1E4F654", VA = "0x7BBC64F654")]
		private void _OnClose(params object[] data)
		{
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3D")]
		[Address(RVA = "0x1E49A34", Offset = "0x1E49A34", VA = "0x7BBC649A34")]
		public void RefreshLevel(int level)
		{
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3E")]
		[Address(RVA = "0x1E48CE4", Offset = "0x1E48CE4", VA = "0x7BBC648CE4")]
		public void RefreshData(Vector3 localpos, AvatarSkillData data)
		{
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0x1E4F9B4", Offset = "0x1E4F9B4", VA = "0x7BBC64F9B4")]
		private int GetTypeByPos(Vector3 pos)
		{
			return 0;
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B40")]
		[Address(RVA = "0x1E4F940", Offset = "0x1E4F940", VA = "0x7BBC64F940")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141050", Offset = "0x1141050")]
		private IEnumerator RefreshNewState()
		{
			return null;
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B41")]
		[Address(RVA = "0x1E4FAF0", Offset = "0x1E4FAF0", VA = "0x7BBC64FAF0")]
		public UIAvatarSkillTipsController()
		{
		}

		// Token: 0x04008738 RID: 34616
		[Token(Token = "0x4008738")]
		[FieldOffset(Offset = "0x58")]
		private UIAvatarSkillTipsView m_View;

		// Token: 0x04008739 RID: 34617
		[Token(Token = "0x4008739")]
		[FieldOffset(Offset = "0x60")]
		private List<AvatarSkillData> m_List;

		// Token: 0x0400873A RID: 34618
		[Token(Token = "0x400873A")]
		[FieldOffset(Offset = "0x68")]
		private int m_skillLength;

		// Token: 0x0400873B RID: 34619
		[Token(Token = "0x400873B")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_Pos;

		// Token: 0x0400873C RID: 34620
		[Token(Token = "0x400873C")]
		[FieldOffset(Offset = "0x78")]
		private Color32 Yellow;

		// Token: 0x0400873D RID: 34621
		[Token(Token = "0x400873D")]
		[FieldOffset(Offset = "0x80")]
		private UIModelAvatarProfile m_Model;

		// Token: 0x020016CA RID: 5834
		[Token(Token = "0x20016CA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F0CD4", Offset = "0x10F0CD4")]
		private sealed class <RefreshNewState>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006B42 RID: 27458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B42")]
			[Address(RVA = "0x1E4FAC4", Offset = "0x1E4FAC4", VA = "0x7BBC64FAC4")]
			[DebuggerHidden]
			public <RefreshNewState>d__14(int <>1__state)
			{
			}

			// Token: 0x06006B43 RID: 27459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B43")]
			[Address(RVA = "0x1E4FB40", Offset = "0x1E4FB40", VA = "0x7BBC64FB40", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006B44 RID: 27460 RVA: 0x0001E600 File Offset: 0x0001C800
			[Token(Token = "0x6006B44")]
			[Address(RVA = "0x1E4FB44", Offset = "0x1E4FB44", VA = "0x7BBC64FB44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x06006B45 RID: 27461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000922")]
			private object Current
			{
				[Token(Token = "0x6006B45")]
				[Address(RVA = "0x1E50164", Offset = "0x1E50164", VA = "0x7BBC650164", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006B46 RID: 27462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B46")]
			[Address(RVA = "0x1E5016C", Offset = "0x1E5016C", VA = "0x7BBC65016C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x06006B47 RID: 27463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000923")]
			private object Current
			{
				[Token(Token = "0x6006B47")]
				[Address(RVA = "0x1E501D4", Offset = "0x1E501D4", VA = "0x7BBC6501D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400873E RID: 34622
			[Token(Token = "0x400873E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400873F RID: 34623
			[Token(Token = "0x400873F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008740 RID: 34624
			[Token(Token = "0x4008740")]
			[FieldOffset(Offset = "0x20")]
			public UIAvatarSkillTipsController <>4__this;
		}
	}
}
