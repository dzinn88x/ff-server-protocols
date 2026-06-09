using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200016A RID: 362
[Token(Token = "0x200016A")]
public class RCC_Camera : MonoBehaviour
{
	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600070C RID: 1804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700005E")]
	public Transform _playerCar
	{
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x23CCC30", Offset = "0x23CCC30", VA = "0x7BBCBCCC30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x23CCC38", Offset = "0x23CCC38", VA = "0x7BBCBCCC38")]
		set
		{
		}
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x23CCEEC", Offset = "0x23CCEEC", VA = "0x7BBCBCCEEC")]
	private void Awake()
	{
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x23CCC40", Offset = "0x23CCC40", VA = "0x7BBCBCCC40")]
	private void GetPlayerCar()
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x23CD004", Offset = "0x23CD004", VA = "0x7BBCBCD004")]
	public void SetPlayerCar(GameObject player)
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x23CD044", Offset = "0x23CD044", VA = "0x7BBCBCD044")]
	private void Update()
	{
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x23CD244", Offset = "0x23CD244", VA = "0x7BBCBCD244")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x23CD338", Offset = "0x23CD338", VA = "0x7BBCBCD338")]
	private void TPS()
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x23CDF00", Offset = "0x23CDF00", VA = "0x7BBCBCDF00")]
	public void Collision(Collision collision)
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x23CE364", Offset = "0x23CE364", VA = "0x7BBCBCE364")]
	public void FixShake()
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000715")]
	[Address(RVA = "0x23CE3B8", Offset = "0x23CE3B8", VA = "0x7BBCBCE3B8")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1133004", Offset = "0x1133004")]
	private IEnumerator FixShakeDelayed()
	{
		return null;
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000716")]
	[Address(RVA = "0x23CE458", Offset = "0x23CE458", VA = "0x7BBCBCE458")]
	public RCC_Camera()
	{
	}

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x18")]
	public Transform playerCar;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody playerRigid;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x28")]
	private Camera cam;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x30")]
	public GameObject pivot;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x38")]
	private GameObject boundCenter;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x40")]
	public RCC_Camera.CameraMode cameraMode;

	// Token: 0x0400068A RID: 1674
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x44")]
	public float distance;

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x48")]
	public float height;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x4C")]
	private float heightDamping;

	// Token: 0x0400068D RID: 1677
	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x50")]
	private float rotationDamping;

	// Token: 0x0400068E RID: 1678
	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x54")]
	public float targetFieldOfView;

	// Token: 0x0400068F RID: 1679
	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x58")]
	public float minimumFOV;

	// Token: 0x04000690 RID: 1680
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x5C")]
	public float maximumFOV;

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x60")]
	public float hoodCameraFOV;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x64")]
	public float wheelCameraFOV;

	// Token: 0x04000693 RID: 1683
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x68")]
	public float maximumTilt;

	// Token: 0x04000694 RID: 1684
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x6C")]
	private float tiltAngle;

	// Token: 0x04000695 RID: 1685
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x70")]
	internal int cameraSwitchCount;

	// Token: 0x04000696 RID: 1686
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 targetPosition;

	// Token: 0x04000697 RID: 1687
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x80")]
	private float speed;

	// Token: 0x04000698 RID: 1688
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 localVector;

	// Token: 0x04000699 RID: 1689
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 collisionPos;

	// Token: 0x0400069A RID: 1690
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x9C")]
	private Quaternion collisionRot;

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0xAC")]
	private float index;

	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public enum CameraMode
	{
		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		TPS,
		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		FPS,
		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		WHEEL,
		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		FIXED
	}

	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E2400", Offset = "0x10E2400")]
	private sealed class <FixShakeDelayed>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x23CE42C", Offset = "0x23CE42C", VA = "0x7BBCBCE42C")]
		[DebuggerHidden]
		public <FixShakeDelayed>d__36(int <>1__state)
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x23CE4F4", Offset = "0x23CE4F4", VA = "0x7BBCBCE4F4", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x23CE4F8", Offset = "0x23CE4F8", VA = "0x7BBCBCE4F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		private object Current
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x23CE6D8", Offset = "0x23CE6D8", VA = "0x7BBCBCE6D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x23CE6E0", Offset = "0x23CE6E0", VA = "0x7BBCBCE6E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		private object Current
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x23CE748", Offset = "0x23CE748", VA = "0x7BBCBCE748", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x20")]
		public RCC_Camera <>4__this;
	}
}
