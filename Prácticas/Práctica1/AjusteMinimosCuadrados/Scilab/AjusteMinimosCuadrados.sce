x = [0 0.2 0.4 0.6 0.8 1 1.2 1.4 1.6 1.8 2]';
y = [4.8 6.2 6.8 7.2 7.8 9.2 8.8 9.2 8.8 9.2 7.8]';
m = size(x,1);
t = (x(1):0.01:x(m))';
n = 1;
A = zeros(m, n+1);
for i=0:n
A(:,i+1) = x.^i;
end
cf = A\y;
p = poly(cf, 'x', 'c');
ft = horner(p, t);
clf()
plot2d(t, ft)
p
