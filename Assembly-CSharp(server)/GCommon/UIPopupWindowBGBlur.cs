using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace GCommon
{
	// Token: 0x0200103A RID: 4154
	[Token(Token = "0x200103A")]
	[Attribute(Name = "RequireComponent", RVA = "0x10EA8F8", Offset = "0x10EA8F8")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class UIPopupWindowBGBlur : MonoBehaviour
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x2032DBC", Offset = "0x2032DBC", VA = "0x7BBC832DBC")]
		public void Cleanup()
		{
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F25")]
		[Address(RVA = "0x2032E80", Offset = "0x2032E80", VA = "0x7BBC832E80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F26")]
		[Address(RVA = "0x2032E84", Offset = "0x2032E84", VA = "0x7BBC832E84")]
		public void OnEnable()
		{
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F27")]
		[Address(RVA = "0x2033680", Offset = "0x2033680", VA = "0x7BBC833680")]
		public void OnDisable()
		{
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06003F28 RID: 16168 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x17000749")]
		public bool Initialized
		{
			[Token(Token = "0x6003F28")]
			[Address(RVA = "0x2032E70", Offset = "0x2032E70", VA = "0x7BBC832E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F29")]
		[Address(RVA = "0x2032EA8", Offset = "0x2032EA8", VA = "0x7BBC832EA8")]
		private void Initialize()
		{
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x2033684", Offset = "0x2033684", VA = "0x7BBC833684")]
		private void OnPostRender()
		{
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2B")]
		[Address(RVA = "0x2027BBC", Offset = "0x2027BBC", VA = "0x7BBC827BBC")]
		public void ExecCommandBuffer(GameObject root)
		{
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2C")]
		[Address(RVA = "0x20337A4", Offset = "0x20337A4", VA = "0x7BBC8337A4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113C178", Offset = "0x113C178")]
		private IEnumerator GetSomeTimeForGlassBlur(GameObject obj)
		{
			return null;
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x2033868", Offset = "0x2033868", VA = "0x7BBC833868")]
		public UIPopupWindowBGBlur()
		{
		}

		// Token: 0x04004F4E RID: 20302
		[Token(Token = "0x4004F4E")]
		[FieldOffset(Offset = "0x18")]
		private Shader m_Shader;

		// Token: 0x04004F4F RID: 20303
		[Token(Token = "0x4004F4F")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		// Token: 0x04004F50 RID: 20304
		[Token(Token = "0x4004F50")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_Camera;

		// Token: 0x04004F51 RID: 20305
		[Token(Token = "0x4004F51")]
		[FieldOffset(Offset = "0x30")]
		private CommandBuffer m_CommandBuffer;

		// Token: 0x04004F52 RID: 20306
		[Token(Token = "0x4004F52")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 m_ScreenResolution;

		// Token: 0x04004F53 RID: 20307
		[Token(Token = "0x4004F53")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_blurTexture;

		// Token: 0x04004F54 RID: 20308
		[Token(Token = "0x4004F54")]
		[FieldOffset(Offset = "0x48")]
		private bool m_NeedExec;

		// Token: 0x04004F55 RID: 20309
		[Token(Token = "0x4004F55")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<GameObject, Vector3> m_lastPosDic;

		// Token: 0x0200103B RID: 4155
		[Token(Token = "0x200103B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA97C", Offset = "0x10EA97C")]
		private sealed class <GetSomeTimeForGlassBlur>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003F2E RID: 16174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F2E")]
			[Address(RVA = "0x203383C", Offset = "0x203383C", VA = "0x7BBC83383C")]
			[DebuggerHidden]
			public <GetSomeTimeForGlassBlur>d__17(int <>1__state)
			{
			}

			// Token: 0x06003F2F RID: 16175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F2F")]
			[Address(RVA = "0x2033904", Offset = "0x2033904", VA = "0x7BBC833904", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003F30 RID: 16176 RVA: 0x00013950 File Offset: 0x00011B50
			[Token(Token = "0x6003F30")]
			[Address(RVA = "0x2033908", Offset = "0x2033908", VA = "0x7BBC833908", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06003F31 RID: 16177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700074A")]
			private object Current
			{
				[Token(Token = "0x6003F31")]
				[Address(RVA = "0x2033D68", Offset = "0x2033D68", VA = "0x7BBC833D68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003F32 RID: 16178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F32")]
			[Address(RVA = "0x2033D70", Offset = "0x2033D70", VA = "0x7BBC833D70", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06003F33 RID: 16179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700074B")]
			private object Current
			{
				[Token(Token = "0x6003F33")]
				[Address(RVA = "0x2033DD8", Offset = "0x2033DD8", VA = "0x7BBC833DD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004F56 RID: 20310
			[Token(Token = "0x4004F56")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004F57 RID: 20311
			[Token(Token = "0x4004F57")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004F58 RID: 20312
			[Token(Token = "0x4004F58")]
			[FieldOffset(Offset = "0x20")]
			public GameObject obj;

			// Token: 0x04004F59 RID: 20313
			[Token(Token = "0x4004F59")]
			[FieldOffset(Offset = "0x28")]
			public UIPopupWindowBGBlur <>4__this;

			// Token: 0x04004F5A RID: 20314
			[Token(Token = "0x4004F5A")]
			[FieldOffset(Offset = "0x30")]
			private UIPopupWindowController <ctrl>5__2;

			// Token: 0x04004F5B RID: 20315
			[Token(Token = "0x4004F5B")]
			[FieldOffset(Offset = "0x38")]
			private int <i>5__3;
		}
	}
}
